using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enable : MonoBehaviour {
    public GameObject Camera;
    public GameObject Player;
    Rigidbody RB;
    Transform Camera2;
    Movement Pause;

    // Use this for initialization
    void Start () {
        Camera2 = GameObject.Find("Main Camera").GetComponent<Transform>();
        RB = Player.GetComponent<Rigidbody>();
        Pause= GameObject.Find("player").GetComponent<Movement>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           if(Pause.IsPause==false)
            {
                Camera.GetComponent<Follow>().enabled = true;
                RB.constraints = RigidbodyConstraints.None;
            }
         
        }
    }
}
