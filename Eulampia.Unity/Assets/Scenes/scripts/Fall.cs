using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour {
    
    public GameObject GameObject1;
    public GameObject GameObject2;
    Rigidbody GM1;
    Rigidbody GM2;
    public GameObject Cube;
    Transform F1;
    Transform F2;
    public Transform Player;
    // Use this for initialization
    void Start()
    {
        GM1 = GameObject.Find("Boulder_Stone_01 (1)").GetComponent<Rigidbody>();
        GM2 = GameObject.Find("Boulder_Stone_01 (2)").GetComponent<Rigidbody>();
        GM1.constraints = RigidbodyConstraints.FreezeAll;
        GM2.constraints = RigidbodyConstraints.FreezeAll;
        Cube.GetComponent<MeshRenderer>().enabled = false;
        F1 = GameObject.Find("Boulder_Stone_01 (1)").GetComponent<Transform>();
        F2 = GameObject.Find("Boulder_Stone_01 (2)").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.position.x > 191)
        {
            GM1.constraints = RigidbodyConstraints.None;
            GM2.constraints = RigidbodyConstraints.None;
            Cube.GetComponent<MeshRenderer>().enabled = true;
        }
        if(F1.position.z < -5)
        {
            GameObject.Destroy(Cube);
        }



    }
	
}
