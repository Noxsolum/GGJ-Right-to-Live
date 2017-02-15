using UnityEngine;
using System.Collections;

public class savedData : MonoBehaviour {

    private string playerName;
    private string playerAge;

    public string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }
    }

    public string PlayerAge
    {
        get { return playerAge; }
        set { playerAge = value; }
    }
    void Update()
    {
        DontDestroyOnLoad(gameObject);
    }
}
