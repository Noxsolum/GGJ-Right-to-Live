using UnityEngine;
using System.Collections;

public class CupMove2 : MonoBehaviour
{

    public bool cupMove2 = false;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
            cupMove2 = true;
        }

        if (cupMove2 == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-0.5f, 0.6f, 0.1f), 0.25f * Time.deltaTime);
        }
    }
}