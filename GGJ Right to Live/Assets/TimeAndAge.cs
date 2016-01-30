using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeAndAge : MonoBehaviour {

    public int attemptCount = 0;
    public GameObject UITimeAndAge;
    public Text Time;
    Text GameOver;
    // Use this for initialization
    void Start()
    {
        UITimeAndAge = gameObject;
        Time = UITimeAndAge.GetComponent<Text>();
        Time.text = "Testing " + attemptCount;
        Time.fontSize = 30;
    }
	
	// Update is called once per frame
	void Update ()
    {
        Time.text = "Testing " + attemptCount;
        Time.fontSize = 30;
    }
}
