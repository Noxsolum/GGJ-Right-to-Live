using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class TextUser : MonoBehaviour {

    public GameObject nameObject;
    public savedData takingtext;
    public GameObject endObject;
    public Text endText;


	// Use this for initialization
	void Start () {
        endObject = gameObject;
        nameObject = GameObject.Find("PlayerData");
        endText = endObject.GetComponent<Text>();
        takingtext = nameObject.GetComponent<savedData>();
	}
	
	// Update is called once per frame
	void Update () {
        endText.text = "Thank you for your sacrifice " + takingtext.PlayerName + "...";
        StartCoroutine(EndGame());

	}

    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Title");
    }
}
