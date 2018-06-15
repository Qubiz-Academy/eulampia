using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class finish : MonoBehaviour {
    public Text text;
	// Use this for initialization
	void Start () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        text.enabled = true;
        
    }
    // Update is called once per frame
    void Update () {
		
	}
}
