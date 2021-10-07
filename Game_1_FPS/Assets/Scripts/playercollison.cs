using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playercollison : MonoBehaviour
{
     public  AudioSource wining;

    // Start is called before the first frame update
    void Start()
    {
       Miangamecontroller.playercollided=false; 
    }

    // Update is called once per frame
    void Update()
    {
        Miangamecontroller.playercollided=false;
        if(Miangamecontroller.zombiealive&& Miangamecontroller.playeralive){
                wining.Play();
        } 
    }
    void OnCollisionEnter(Collision other){
        if(other.collider.tag=="enemy"){
           Miangamecontroller.playerhealth-=2;

           Miangamecontroller.playercollided=true;

           if(Miangamecontroller.playerhealth<2){
               Miangamecontroller.playeralive= false;
           }
           
           // Debug.Log("hit enemy");
            
        }
        else
           {
               Miangamecontroller.playercollided=false;
           }
        
    }
}
