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

    private void Start()
    {
        myRb = transform.GetComponent<Rigidbody>();
    }



    void Update()
    {     
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        input.Normalize();
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
