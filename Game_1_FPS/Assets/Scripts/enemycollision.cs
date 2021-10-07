using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//var collider =false;
public class enemycollision : MonoBehaviour
{
    //public GameObject enemy;
    
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision other){
        if(other.collider.name=="Player"){
            if(Miangamecontroller.playerattacked){
                Miangamecontroller.zombiehealth -=2;
                Debug.Log("zombie hit");
            }
            
        }
        else
        {
            //collider =false;
        }
        
    }
}
