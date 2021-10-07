using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class bloodadd : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public RawImage rawimage;
    // Start is called before the first frame update
    void Start()
    {
        rawimage.enabled =false;
    }

    // Update is called once per frame
    void Update()
    {
        
       //if player collided with enemy
       if(Miangamecontroller.playercollided){
        rawimage.enabled =true;
        StartCoroutine(waittoshowimage());
       }
       else
       {
           rawimage.enabled =false;
       }
       
    }
    

    IEnumerator waittoshowimage()  //  <-  its a standalone method
    {
        //Debug.Log("Hello");
        Miangamecontroller.playercollided =true;
        rawimage.enabled =true;
        yield return new WaitForSeconds(3.0f);
        
        Miangamecontroller.playercollided =false;
        //Debug.Log("ByeBye");
    }
    
}
