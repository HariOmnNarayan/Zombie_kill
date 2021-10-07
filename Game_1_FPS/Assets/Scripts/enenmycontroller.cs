using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enenmycontroller : MonoBehaviour
{

    public GameObject player_container;
    public GameObject enemy_container;

    public  AudioSource m_MyAudioSource;


    
    //public GameObject zombieprefab;
    public float speed = 1f;
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        //m_MyAudioSource = GetComponent<AudioSource>();
        //m_MyAudioSource.Play();
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(player_container.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player_container.transform.position);

        if(!Miangamecontroller.zombiealive){
            m_MyAudioSource.Stop();
            
            //GameObject zombieinstance = Instantiate(zombieprefab);
            //zombieinstance.transform.position = enemy_container.transform.position;
        }
        else
        {
          //  m_MyAudioSource.Play();
        }
    }

    
}
