using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public GameObject player;
    public float speed = 1f;
    public float acceleration = 2.5f;
    public float RotateSpeed = 180f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w")){
            player.transform.position += transform.forward * speed * Time.deltaTime ;// transform.forward;
            if(Input.GetKey("space")){
               player.transform.position += transform.forward * acceleration  * Time.deltaTime ;// transform.forward;
            }  
        }
        if(Input.GetKey("s")){
            player.transform.position -= transform.forward * speed * Time.deltaTime ;// transform.forward;
            if(Input.GetKey("space")){
               player.transform.position -= transform.forward * speed * acceleration * Time.deltaTime ;// transform.forward;
            } 
            
        }
        if(Input.GetKey("d")){
            //player.transform.Rotate(0,90,0,Space.Self);
            //player.transform.Rotate(-Vector3.up * RotateSpeed * Time.deltaTime);
            player.transform.localRotation = Quaternion.Euler(0, -90, 0);
        }
        if(Input.GetKey("a")){
           //player.transform.Rotate(0,-90,0,Space.World);
            //transform.Rotate(-Vector3.up * RotateSpeed * Time.deltaTime);
            player.transform.localRotation = Quaternion.Euler(0, 90, 0);
        }
    }
}
