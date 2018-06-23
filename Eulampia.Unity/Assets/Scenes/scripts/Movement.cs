using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Movement : Checkpoint
{
    public Rigidbody rb;
    public Transform transform;
    public bool IsGrounded { get; set; }
    public bool IsPause { get; set; }
    public bool SP { get; set; }
    public bool SP2 { get; set; }
    public bool IsJumping { get; set; }
    private ParticleSystem Part;

    Rigidbody RigidBodyP;
    public void Start()
    {
        Part= GameObject.Find("SparksEffect").GetComponent<ParticleSystem>();
    }
    private void OnCollisionEnter(Collision collisionInfo)
    {
        IsJumping = false;
        if (collisionInfo.collider.tag == "ground")
        {
            IsGrounded = true;
            Part.Play();
        }
        else if (collisionInfo.collider.tag == "specialPlatform")
        {
            SP = true;
            Part.Play();
            IsGrounded = true;
        }
        else
        {
            IsGrounded = false;
            SP = false;
           
        }

        if (collisionInfo.collider.tag == "specialplatfom2")
        {
            SP2 = true;
            Part.Play();
            IsGrounded = true;
        }
        else
        {
            SP2 = false;
        }

        if (collisionInfo.collider.tag == "Obs")
        {
            if (checkpointS == new Vector3(0.22f, 0.9076411f, -1.84f))
            {
                transform.position = new Vector3(0.22f, 0.9076411f, -1.84f);
            }
            else
            {
                transform.position = new Vector3(86.2f, 0.95f, -1.84f);
            }
        }

        if (collisionInfo.collider.tag == "finish")
        {
            rb.AddForce(100, 5000, 0);
        }
    }

    public GameObject Pause;
    public void pause()
    {
        if (IsPause)
        {
            Pause.SetActive(false);
            RigidBodyP.constraints = RigidbodyConstraints.None;
            IsPause = false;
        }
        else
        {
            RigidBodyP = GetComponent<Rigidbody>();

            RigidBodyP.constraints = RigidbodyConstraints.FreezeAll;

            Pause.SetActive(true);
            IsPause = true;
        }
    }

    public GameObject platform;
    public void platformPosition()
    {
        if (transform.position.z > platform.transform.position.z + 2.3f)
            transform.position = new Vector3(transform.position.x, transform.position.y, platform.transform.position.z + 2.3f);
        else if (transform.position.z < platform.transform.position.z - 2.3f)
            transform.position = new Vector3(transform.position.x, transform.position.y, platform.transform.position.z - 2.3f);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            pause();
        
        if (SP)
            platformPosition();

        if (SP2)
        {
            RigidBodyP = GetComponent<Rigidbody>();

            RigidBodyP.constraints = RigidbodyConstraints.FreezePositionZ;
        }
        else
        {
            RigidBodyP = GetComponent<Rigidbody>();

            RigidBodyP.constraints = RigidbodyConstraints.None;
        }

        if (Input.GetKey(KeyCode.D) && !IsJumping)
            rb.AddForce(40, 0, 0);
        else if (Input.GetKey(KeyCode.W) && !IsJumping)
            rb.AddForce(0, 0, 40);
        else if (Input.GetKey(KeyCode.A) && !IsJumping)
            rb.AddForce(-40, 0, 0);
        else if (Input.GetKey(KeyCode.S) && !IsJumping)
            rb.AddForce(0, 0, -40);

        if (transform.position.y > 0.5)
        {
            if (IsGrounded && Input.GetKeyDown(KeyCode.Space) && !IsJumping)
            {
                rb.AddForce(0, 400, 0);
                IsJumping = true;
                IsGrounded = false;
                if (SP)
                    SP = false;
                if (SP2)
                    SP2 = false;
            }
        }

        if (transform.position.y < -1)
        {
            transform.position = checkpointS;
        }
    }
}
