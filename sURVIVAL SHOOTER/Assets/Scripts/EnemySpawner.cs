using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject spawnPoint;
    public GameManager gm;


    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
        InvokeRepeating("Spawn", 1.0f,5.0f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Spawn()
    {
        Instantiate(enemy, spawnPoint.transform.position, spawnPoint.transform.rotation);
        if (gm.mascarillaOn)
        {
            gm.FrenoMascarillaAux();
        }
    }
}
