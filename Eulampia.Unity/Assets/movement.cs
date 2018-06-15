using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    public Rigidbody rb;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.D))
            rb.AddForce(10, 0, 0);
        else
                 if (Input.GetKeyDown(KeyCode.W))
                    rb.AddForce(0, 0, 10);
                 else
                        if (Input.GetKeyDown(KeyCode.A))
                            rb.AddForce(-10, 0, 0);
                         else
                                if (Input.GetKeyDown(KeyCode.S))
                                     rb.AddForce(0, 0, -10);
                             
        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(0, 10, 0);

    }
}
