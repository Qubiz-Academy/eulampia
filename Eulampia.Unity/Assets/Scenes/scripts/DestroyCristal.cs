using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCristal : Follow {
    public GameObject GameObject1;
    public GameObject GameObject2;
    public ParticleSystem Part;
    public GameObject Camera;
    Transform  Camera2;
    public GameObject Player;
    Rigidbody RB;
    public GameObject Text;
    public void OnTriggerEnter(Collider other)
    {
        
        Part.Play();
        GameObject.Destroy(GameObject2);
        Camera.GetComponent<Follow>().enabled = false;
        Text.SetActive(true);
        GameObject.Destroy(GameObject1);
        
        Camera2.position = new Vector3(175.69f, 1.92f, -11.428f);
        RB.constraints = RigidbodyConstraints.FreezeAll;

    }
    void Start () {
        Part.Stop();
        Camera2 = GameObject.Find("Main Camera").GetComponent<Transform>();
        RB= Player.GetComponent<Rigidbody>();
        
    }
	
	// Update is called once per frame
	void Update () {
		
            
    }
}
