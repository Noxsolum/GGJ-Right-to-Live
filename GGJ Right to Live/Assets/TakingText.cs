using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TakingText : MonoBehaviour {

    public GameObject textObject;
    public GameObject SaveObject;
    public savedData dataScript;
    public Button saveButton;
    public InputField inputObject;

	// Use this for initialization
	void Start () {
        SaveObject = GameObject.Find("PlayerData");
        Button _saveButton = saveButton.GetComponent<Button>();
        _saveButton.onClick.AddListener(TaskOnClick);
        textObject = GameObject.FindWithTag("TextCreator");
        inputObject = textObject.GetComponent<InputField>();
        dataScript = SaveObject.GetComponent<savedData>();
    }
	
	// Update is called once per frame
    void TaskOnClick()
    {
        dataScript.PlayerName = inputObject.text;
    }
}
