using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject[] enemy;
    public Transform SpawnPoint;
    public float SpawnInterval = 40f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnHere", 0f, SpawnInterval );
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnHere()
    {
        GameObject Goblin = enemy[0];
        GameObject EnemyGoblin = Instantiate(Goblin, SpawnPoint.position, Random.rotation); 
    }
}
