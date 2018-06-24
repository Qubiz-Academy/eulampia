using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint2 : MonoBehaviour {
    public Checkpoint Checkpoint;
    Checkpoint CKS;
	// Use this for initialization
	void Start () {
        CKS = Checkpoint.GetComponent<Checkpoint>();
	}
    public void OnTriggerEnter(Collider other)
    {
        CKS.checkpointS= new Vector3(163.23f, 0.95f, -7.09f);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
