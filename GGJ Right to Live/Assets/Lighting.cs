using UnityEngine;
using System.Collections;

public class Lighting : MonoBehaviour {

    public Animator menuAnim;

    void Awake()
    {
        menuAnim = GetComponent<Animator>();
    }

    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void LightFadeIn()
    {
        menuAnim.SetTrigger("FadingOut");
    }
}
