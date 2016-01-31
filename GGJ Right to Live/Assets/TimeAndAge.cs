using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeAndAge : MonoBehaviour {

    static public int attemptCount = 0;
    public GameObject UITimeAndAge;
    public GameObject BallScript;
    public Text Time;
    Text GameOver;
    // Use this for initialization
    void Start()
    {
        attemptCount = attemptCount + 1;
        BallScript = GameObject.FindWithTag("GameController");

        UITimeAndAge = gameObject;
        Time = UITimeAndAge.GetComponent<Text>();
        Time.text = "Rituals attended: " + attemptCount;
        Time.fontSize = 30;
    }
	
	// Update is called once per frame
	void Update ()
    {
        Time.text = "Rituals attended: " + attemptCount;
        Time.fontSize = 30;

        WhichBall ballVari = BallScript.GetComponent<WhichBall>();
        if (ballVari.nextAttempt == true)
        {
            attemptCount++;
            ballVari.nextAttempt = false;
        }
    }
}
