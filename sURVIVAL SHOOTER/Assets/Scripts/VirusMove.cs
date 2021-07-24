using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class VirusMove : MonoBehaviour
{
    public Transform player;
    Vector3 destination;
    public NavMeshAgent virus;
    // Start is called before the first frame update
    void Start()
    {
        //Pilla el navmesh del virus para que encuentre por AI al Objetivo ( El player)
        virus = GetComponent<NavMeshAgent>();
        destination = virus.destination;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(destination,player.position) > 0.1f)
        {
            
            destination = player.position;
            virus.destination = destination;
           
        }
    }
}
