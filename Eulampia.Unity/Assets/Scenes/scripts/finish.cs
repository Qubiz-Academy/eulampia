using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class finish : MonoBehaviour {
    public GameObject CompleteLevelUI;
    // Use this for initialization
    
    private void OnTriggerEnter(Collider other)
    {
        CompleteLevelUI.SetActive(true);
    }
    // Update is called once per frame
    
}
