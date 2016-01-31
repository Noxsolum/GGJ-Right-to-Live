using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TakingText : MonoBehaviour {

    public string sSave;
    public GameObject newObject;
    public InputField inputObject;

	// Use this for initialization
	void Start () {
        newObject = GameObject.FindWithTag("TextCreator");
        inputObject = newObject.GetComponent<InputField>();
	}
	
	// Update is called once per frame
	void Update () {
        sSave = inputObject.text;
        print(sSave);
        DontDestroyOnLoad(gameObject);
	}
}
