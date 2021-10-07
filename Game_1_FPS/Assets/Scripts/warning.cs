using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class warning : MonoBehaviour
{

    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.enabled =false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!Miangamecontroller.zombiealive){
            StartCoroutine(waittoshowtext());
        }
        else
        {
            scoreText.enabled =false;
        }
    }

    IEnumerator waittoshowtext()  //  <-  its a standalone method
    {
        scoreText.enabled =true;
        
        yield return new WaitForSeconds(1.0f);
        
        
    }
}
