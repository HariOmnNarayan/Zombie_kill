using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class zombieCOntroller : MonoBehaviour
{

    Animator animator;

    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }



    private void Update()
    {
        if(Miangamecontroller.playercollided){
            animator.SetBool("nearby",true);
            
            
        }
        else{
            animator.SetBool("nearby",false);
        }
        
        if(Miangamecontroller.zombiehealth<1){
            animator.SetFloat("health", 0);
            Miangamecontroller.zombiealive= false;
            Miangamecontroller.play=true;
        }

    }
}
