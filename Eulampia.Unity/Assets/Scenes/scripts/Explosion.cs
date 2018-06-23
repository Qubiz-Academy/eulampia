using UnityEngine;

public class Explosion : MonoBehaviour
{
    public ParticleSystem part;
    private bool IsPlayed { get; set; }
    private Movement mv;

    void Start()
    {
        mv = GameObject.Find("player").GetComponent<Movement>();
        IsPlayed = false;
        part.Stop();
    }
    public void Play()
    {
        part.Play();
    }
    // Update is called once per frame
    void Update()
    {
        if (mv.transform.position.x < 36 && mv.transform.position.x > 33)
            if (!IsPlayed)
                Play();
    }
}
