using UnityEngine;
using System.Collections;

public class WhichBall : MonoBehaviour {

    public int x;
    public Vector3 Right = new Vector3(0.5f, 0.19f, 0);
    public Vector3 Left = new Vector3(-0.5f, 0.19f, 0);
    public Transform whiteBall;
    public Transform blackBall;

	// Use this for initialization
	void Start ()
    {
        x = Random.Range(0, 11);
        if (x <= 5)
        {
            Instantiate(whiteBall, Right, Quaternion.identity);
            Instantiate(blackBall, Left, Quaternion.identity);
        }
        else if (x > 5) {
            Instantiate(whiteBall, Left, Quaternion.identity);
            Instantiate(blackBall, Right, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
