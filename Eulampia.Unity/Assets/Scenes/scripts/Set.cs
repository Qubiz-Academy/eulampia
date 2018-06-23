using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set : MonoBehaviour {
    public Animation Animation;
    public Transform player;
    public Animator Animator;

    

    // Use this for initialization
    void Start () {
        Animator.GetComponent<Animation>();
        Animation.Stop();
      
	}
    public void Play()
    {
        Animation.Play();
    
    }
    // Update is called once per frame
    void Update () {
        if (player.position.x > 17)
            Play();
	}
}
