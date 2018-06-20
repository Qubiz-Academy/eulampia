using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
public class movement : checkpoint {
    public Rigidbody rb;
    public Transform transform;
    public bool IsGrounded { get; set; }
    public bool IsPause { get; set; }
    public bool SP { get; set; }
    Rigidbody RigidBodyP;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "ground")
        {

            IsGrounded = true;
        }
        if (collisionInfo.collider.tag == "specialPlatform")
        {
            SP = true;
            IsGrounded = true;
        }
        else
            SP = false;

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
        transform.position = new Vector3(transform.position.x, transform.position.y, platform.transform.position.z);
    }
    public void Update()
    {

       

        if (Input.GetKeyDown(KeyCode.Escape))
            pause();

        if (SP == true && !Input.anyKey)
            platformPosition();




        if (Input.GetKey(KeyCode.D) && IsGrounded)

            rb.AddForce(40, 0, 0);


        else
                 if (Input.GetKey(KeyCode.W) && IsGrounded)

            rb.AddForce(0, 0, 40);


        else
                        if (Input.GetKey(KeyCode.A) && IsGrounded)

            rb.AddForce(-40, 0, 0);



        else
                                if (Input.GetKey(KeyCode.S) && IsGrounded)

            rb.AddForce(0, 0, -40);




        if (transform.position.y > 0.5)
            if (IsGrounded && Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(0, 400, 0);
                IsGrounded = false;
                if (SP)
                    SP = false;
            }

        if (transform.position.y < -1)
        {
            transform.position = checkpointS;
        }
    }
}
