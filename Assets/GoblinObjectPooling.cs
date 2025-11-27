using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinObjectPooling : MonoBehaviour
{

    public GameObject prefab;

    public Queue<GameObject> pool = new Queue<GameObject>();


    void Awake()
    {
        for (int i=0; i<4; i++)
        {
            GameObject goblinObject = Instantiate(prefab);
            goblinObject.SetActive(false);
            pool.Enqueue(goblinObject);

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject Get()
    {
        if (pool.Count == 0)
        {
            GameObject ObjectPooled = Instantiate(prefab);
            ObjectPooled.SetActive(false);
            pool.Enqueue(ObjectPooled);
        }

        GameObject pooledObject = pool.Dequeue();
        pooledObject.SetActive(true);
        return pooledObject;
    }

    public void ReturnToPool(GameObject goblinObject)
    {
        goblinObject.SetActive(false);
        pool.Enqueue(goblinObject);
    }
}
