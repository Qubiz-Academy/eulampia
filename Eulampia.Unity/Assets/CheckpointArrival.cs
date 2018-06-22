using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointArrival : MonoBehaviour {
    public ParticleSystem part;
    public Movement ms; 
	// Use this for initialization
	void Start () {
        ms = GameObject.Find("player").GetComponent<Movement>();

        part.Stop();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
