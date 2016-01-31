using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class TextUser : MonoBehaviour {

    public GameObject nameObject;
    public TakingText takingtext;
    public GameObject endObject;
    public Text endText;


	// Use this for initialization
	void Start () {
        endObject = gameObject;
        nameObject = GameObject.FindWithTag("TextAdder");
        endText = endObject.GetComponent<Text>();
        takingtext = nameObject.GetComponent<TakingText>();
	}
	
	// Update is called once per frame
	void Update () {
        endText.text = "Thank you for your sacrifice " + takingtext.sSave + "...";
        StartCoroutine(EndGame());

	}

    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Title");
    }
}
