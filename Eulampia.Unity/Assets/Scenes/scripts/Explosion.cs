using UnityEngine;

public class Explosion : MonoBehaviour
{
    public ParticleSystem part;

    private Movement mv;

    void Start()
    {
        mv = GameObject.Find("player").GetComponent<Movement>();

        part.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (mv.transform.position.x < 33 && mv.transform.position.x > 30)
            part.Play();
    }
}
