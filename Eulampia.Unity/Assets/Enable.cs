using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enable : MonoBehaviour {
    public GameObject Camera;
    public GameObject Player;
    Rigidbody RB;
    Transform Camera2;
    private int i = 0;
    // Use this for initialization
    void Start () {
        Camera2 = GameObject.Find("Main Camera").GetComponent<Transform>();
        RB = Player.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            i++;
            if(i==1)
            {
                Camera.GetComponent<Follow>().enabled = true;
                RB.constraints = RigidbodyConstraints.None;
            }
         
        }
    }
}
