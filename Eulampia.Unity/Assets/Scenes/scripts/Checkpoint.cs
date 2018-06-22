
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    // Use this for initialization
    public int i = 0;
    public CheckpointArrival Part;
    private void Start()
    {
        Part = GameObject.Find("PlasmaExplosionEffect").GetComponent<CheckpointArrival>();
    }
    public Vector3 checkpointS = new Vector3(0.22f, 0.9076411f, -1.84f);
    private void OnTriggerEnter(Collider other)
    {
        i++;
        if (i == 1)
        {
            
            checkpointS = new Vector3(86.2f, 0.95f, -1.84f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
