using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class finish : MonoBehaviour {
    public GameObject CompleteLevelUI;
    // Use this for initialization
    void Start () {
        
	}
    private void OnCollisionEnter(Collision collision)
    {
        CompleteLevelUI.SetActive(true);


    }
    // Update is called once per frame
    void Update () {
		
	}
}
