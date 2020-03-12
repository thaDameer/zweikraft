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
       
      //  myRb.MovePosition(moveDir * Time.deltaTime);
       
    }

    private void FixedUpdate() 
    {
        myRb.velocity += new Vector3(input.x, myRb.velocity.y, input.y).normalized * moveSpeed * Time.fixedDeltaTime;        
    }

    

    
}
