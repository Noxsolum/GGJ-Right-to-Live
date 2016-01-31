using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class WhichBall : MonoBehaviour
{
    public int x;
    public bool nextAttempt = false;
    public bool cupMove1 = false;
    public bool cupMove2 = false;
    public bool blackRight = false;
    public bool blackLeft = false;
    public Vector3 Right = new Vector3(0.5f, 0.19f, 0);
    public Vector3 Left = new Vector3(-0.5f, 0.19f, 0);
    public Transform whiteBall;
    public Transform blackBall;
    public GameObject cupOne;
    public GameObject cupTwo;
    public GameObject textScript;
    public TimeAndAge timeScript;
   // public Animator menuAnim;

    // ============================
    // Use this for initialization
    // ============================
    void Start()
    {
        // ================
        // Finds the Cups
        // ===============
        cupOne = GameObject.FindWithTag("cupOne");
        cupTwo = GameObject.FindWithTag("cupTwo");
        //menuAnim = GetComponent<Animator>();
        textScript = GameObject.FindWithTag("TextCreator");

        // ==============================================================================
        // Makes the ball spawn randomly between two points at the beginning of the game
        // ==============================================================================
        x = Random.Range(0, 11);
        if (x <= 5)
        {
            Instantiate(whiteBall, Right, Quaternion.identity);
            Instantiate(blackBall, Left, Quaternion.identity);
            blackLeft = true;
            blackRight = false;
        }
        else if (x > 5)
        {
            Instantiate(whiteBall, Left, Quaternion.identity);
            Instantiate(blackBall, Right, Quaternion.identity);
            blackRight = true;
            blackLeft = false;
        }
    }

    // ================================
    // Update is called once per frame
    // ================================
    void Update()
    {
        // =================
        // Clicking objects
        // =================
        if (Input.GetMouseButtonDown(0))
        {
            // =======================================
            // Creates a ray for clicking the objects
            // =======================================
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 10, Color.red);
            print("Mouse clicked");

            // =======================
            // What does the ray hit?
            // =======================
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.collider.tag == "cupOne")
                {
                    cupMove1 = true;
                    print("Hit Something");
                }
                if (hit.collider.tag == "cupTwo")
                {
                    cupMove2 = true;
                    print("Hit Something");
                }
            }
        }

        // ==============================
        // Translate the cups if clicked
        // ==============================
        if (cupMove1 == true)
        {
            // Cup on the Right
            cupOne.transform.position = Vector3.MoveTowards(cupOne.transform.position, new Vector3(0.5f, 0.6f, 0.1f), 0.25f * Time.deltaTime);
            cupTwo.transform.position = Vector3.MoveTowards(cupTwo.transform.position, new Vector3(-0.5f, 0.6f, 0.1f), 0.25f * Time.deltaTime);
            if (blackRight == true)
            {
                print("Game Over");
                StartCoroutine(WaitGO());
            }
            else
            {
                print("Continue");
               // StartCoroutine(WaitLight());
             //   menuAnim.SetTrigger("FadingOut");
                StartCoroutine(WaitRedo());
            }
        }
        if (cupMove2 == true)
        {
            // Cup on the Left
            cupOne.transform.position = Vector3.MoveTowards(cupOne.transform.position, new Vector3(0.5f, 0.6f, 0.1f), 0.25f * Time.deltaTime);
            cupTwo.transform.position = Vector3.MoveTowards(cupTwo.transform.position, new Vector3(-0.5f, 0.6f, 0.1f), 0.25f * Time.deltaTime);
            if (blackLeft == true)
            {
                print("Game Over");
                StartCoroutine(WaitGO());
            }
            else
            {
                print("Continue");
                //StartCoroutine(WaitLight());
             //   menuAnim.SetTrigger("FadingOut");
                StartCoroutine(WaitRedo());
            }
        }
        // ============
        // Live of Die
        // ============



    }
    IEnumerator WaitLight()
    {
        yield return new WaitForSeconds(3);
    }

    IEnumerator WaitGO()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("End");
    }

    IEnumerator WaitRedo()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Main");
    }
}
