using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        int local = Miangamecontroller.playerhealth;
        int zombie = Miangamecontroller.zombiehealth;
        if(local>0 && zombie>0){
            scoreText.text= "Health : "+ local  + "  zombie  "+ zombie;
        }
        else if(local>0){
            scoreText.text= "Zombie Died";
        }
        else
        {
            scoreText.text= "Player Died";
        }
    }
}
