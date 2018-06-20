using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour {

    public ParticleSystem part;
    movement mv;
    
	void Start () {
        part.Stop();
	}
	
	// Update is called once per frame
	void Update () {
        if (mv.transform.position.x < 35 && mv.transform.position.x > 30)
            part.Play();
	}
}
