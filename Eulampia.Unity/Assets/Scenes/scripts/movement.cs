using UnityEngine.SceneManagement;
using UnityEngine;

public class movement : checkpoint {
    public Rigidbody rb;
    public Transform transform;
    public bool IsGrounded { get; set; }

    
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "ground")
        {
           
            IsGrounded = true;
        }
        if (collisionInfo.collider.tag == "Obs")
        {
            transform.position = new Vector3(0.22f, 0.9076411f, -1.84f);

        }
        if (collisionInfo.collider.tag == "finish")
        {
            rb.AddForce(100, 1000, 0);


        }
    }

    // Update is called once per frame
    void Update () {
        
        if (Input.GetKey(KeyCode.D) && IsGrounded)
         
            rb.AddForce(50, 0, 0);
           
        
        else
                 if (Input.GetKey(KeyCode.W) && IsGrounded)
                
                    rb.AddForce(0, 0, 50);
                    
                    
                 else
                        if (Input.GetKey(KeyCode.A) && IsGrounded)
                          
                            rb.AddForce(-50, 0, 0);
                             
                          
    
                         else
                                if (Input.GetKey(KeyCode.S) && IsGrounded)
                               
                                     rb.AddForce(0, 0, -50);
                                    
                                   
        if (transform.position.y > 0.5 && transform.position.y < 1 && (transform.position.x<90 || transform.position.x >113))
            if (IsGrounded && Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(0, 8, 0, ForceMode.VelocityChange);
                IsGrounded = false;
            }

        if (transform.position.y < -1 )
            transform.position = checkpointS;
        }
}
