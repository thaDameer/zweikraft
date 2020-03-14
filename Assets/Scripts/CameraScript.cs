using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public static CameraScript instance;
    public Camera mainCamera; 
    public Transform player;
    public Vector3 offset;

    private void Awake() 
    {
        if(instance != null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    private void FixedUpdate() 
    {
        Vector3 followVec = offset + player.transform.position;
        transform.position = Vector3.Lerp(transform.position, followVec, 2f * Time.deltaTime);   
    }
}
