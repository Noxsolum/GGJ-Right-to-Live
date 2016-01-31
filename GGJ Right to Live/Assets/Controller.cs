using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class Controller : MonoBehaviour {

    public Animator menuAnim;

    void Awake()
    {
        menuAnim = GetComponent<Animator>();
    }

    public void LoadMain()
    {
        menuAnim.SetTrigger("FadingOut");
        StartCoroutine(WaitMain());
    }

    public void LoadCC()
    {
        menuAnim.SetTrigger("FadingOut");
        StartCoroutine(WaitCC());
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    IEnumerator WaitCC()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("CreateCharacter");
    }

    IEnumerator WaitMain()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("Main");
    }
}
