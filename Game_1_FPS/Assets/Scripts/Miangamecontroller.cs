using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Miangamecontroller : MonoBehaviour
{
    /*public GameObject player;
    public Text scoreText;*/

    public  static int playerhealth = 50;
    public  static bool playeralive = true;
    public  static bool playercollided = false;

    public static bool playerattacked = false;

    public static int zombiehealth =10;

    public static bool zombiealive = true;

    public static bool play = false;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // scoreText.text= "Health : "+ player.health;//.ToString();
    }
}
