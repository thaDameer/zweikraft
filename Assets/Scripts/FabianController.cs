using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FabianController : MonoBehaviour
{
    public float moveSpeed;
    Vector2 input;
    Rigidbody myRb;
    Camera mainCam;
    Vector3 moveDir;
    public Animator anim; 
    float rotAngle;
    float rotSpeed = 10f;

    private void Start()
    {
        myRb = transform.GetComponent<Rigidbody>();
    }



    void Update()
    {     
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");
        input.Normalize();
        rotAngle = Mathf.Clamp(rotAngle, -45,45);
            anim.SetFloat("Turning", Mathf.Lerp(0, input.x,1f));
        if(input.x != 0)
        {
            if (input.x>0)
            {
               // this.transform.rotation = Vector3.RotateTowards
            }
        }

        //myRb.MovePosition(moveDir * Time.deltaTime);
       
    }

    private void FixedUpdate() 
    {
 
        myRb.velocity += new Vector3(input.x, 0, input.y) * moveSpeed * Time.fixedDeltaTime;       
  
        //myRb.AddForce(Vector3.down * 0.1f, ForceMode.Acceleration); 
    }
    
    private void OnCollisionEnter(Collision other) {
        //myRb.useGravity = true;
        myRb.AddForce(Vector3.down * 3f, ForceMode.Impulse);
        myRb.velocity = Vector3.zero;
    }

    

    
}
