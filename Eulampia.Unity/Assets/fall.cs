using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour {
    public Transform Player;
    private Time Time;
    public int Nr;
    public Rigidbody Rb;
    Movement MV;
    private readonly Animation Animation;
   
	void Start () {
        Nr = Time.frameCount;
        MV= GameObject.Find("player").GetComponent<Movement>();
        Animation.GetComponent<Animator>();

        
    }
	
	// Update is called once per frame
	void Update () {
        if (MV.IsGrounded)
        {
            Nr++;
            if (Nr % 100 == 0 && Player.position.x > 26 && Player.position.x < 32)
            {
                Animation.Stop();
                Rb.AddForce(0, -1000, 0);
            }
               
        }

    }
}
