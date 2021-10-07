using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        float health = animator.GetFloat("health");
        if(Miangamecontroller.playerhealth<2){
            animator.SetFloat("health",0);
        }
        if(Input.GetKey("w")){
            animator.SetBool("iswalking" , true);
            if(Input.GetKey("space")){
                animator.SetBool("isrunning", true);
            }  
            
        }
        if(!Input.GetKey("space")){
                animator.SetBool("isrunning", false);
        }  
        if(!Input.GetKey("w")){
            animator.SetBool("iswalking" , false);
        }
        if(Input.GetMouseButtonDown(0)){
            animator.SetBool("isattacking", true);
            Miangamecontroller.playerattacked = true;
            //Debug.Log("zombie attacked");
        }
        if(!Input.GetMouseButtonDown(0)){
            animator.SetBool("isattacking", false);
            //Miangamecontroller.playerattacked = false;
        }
        if(Input.GetKey("s")){
            animator.SetBool("goingback" , true);
            if(Input.GetKey("space")){
                animator.SetBool("isrunning", true);
            } 
        }
        if(!Input.GetKey("s")){
            animator.SetBool("goingback" , false);
        }
        /*if(Input.GetKey("d")){
            animator.SetBool("leftturn" , true);
        }
        if(!Input.GetKey("d")){
            animator.SetBool("leftturn" , false);
        }
        if(Input.GetKey("a")){
            animator.SetBool("rightturn" , true);
        }
        if(!Input.GetKey("a")){
            animator.SetBool("rightturn" , false);
        }
        */
    }
}
