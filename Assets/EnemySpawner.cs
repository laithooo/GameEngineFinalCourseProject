using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject[] enemy;
    public Transform SpawnPoint;
    public float SpawnInterval = 10f;
    public GoblinObjectPooling goblinPool;

    // Start is called before the first frame update
    void Start()
    {
        goblinPool = gameObject.AddComponent<GoblinObjectPooling>();
        goblinPool.prefab = enemy[0];
        InvokeRepeating("SpawnHere", 2f, SpawnInterval );
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnHere()
    {
        GameObject Goblin = goblinPool.Get();
        Goblin.transform.position =  SpawnPoint.position;
        Goblin.transform.rotation = SpawnPoint.rotation;
    }
}
