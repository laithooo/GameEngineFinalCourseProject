using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class HealthUI : MonoBehaviour, IHealthObserver
{
    
    [SerializeField] private TextMeshProUGUI healthText;
    public PlayerHealth playerHealth;

    void Start()
    {
        if (HealthManager.Instance != null && HealthManager.Instance.player != null)
        {
            playerHealth = HealthManager.Instance.player;
            playerHealth.RegisterObserver(this);
        }
    }

    public void OnEnable()
    {
        if (playerHealth != null)
        {
            playerHealth.OnHealthChanged += OnHealthChanged;
        }
    }

    public void OnDisable()
    {
        if (playerHealth != null)
        {
            playerHealth.OnHealthChanged -= OnHealthChanged;
        }
    }

    public void OnHealthChanged(int currentHealth, int maxHealth)
    {
        if (healthText != null)
            healthText.text = $"Health: {currentHealth}";
    }
}
