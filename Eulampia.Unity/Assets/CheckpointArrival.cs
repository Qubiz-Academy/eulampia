using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointArrival : MonoBehaviour {
    public ParticleSystem part;
    private Movement ms;
    // Use this for initialization
    private int i = 0;
	void Start () {
        ms = GameObject.Find("player").GetComponent<Movement>();

        part.Stop();
    }
	
	// Update is called once per frame
	void Update () {
        if (ms.transform.position.x >= 83 && ms.transform.position.x <= 85)
        {
            i++;
            if (i == 1) 
                part.Play();
        }
           
	}
}
