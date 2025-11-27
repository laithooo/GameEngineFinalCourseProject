using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{

    public static HealthManager Instance { get; private set; }

    public PlayerHealth player;

    void Awake()
    {
    
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
