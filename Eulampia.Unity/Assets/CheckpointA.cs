using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointA : MonoBehaviour
{

    public ParticleSystem part;
    private Movement ms;
    private bool Played { get; set; }
    // Use this for initialization

    void Start()
    {
        ms = GameObject.Find("player").GetComponent<Movement>();

        part.Stop();
        Played = false;
    }
    public void Partplay()
    {
        part.Play();
        Played = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (ms.transform.position.x > 81 && ms.transform.position.x < 84)
            if (!Played)
                Partplay();

    }
}