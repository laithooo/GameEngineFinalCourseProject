using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] int startingHealth = 100;
    [SerializeField] int maxHealth = 100;
    [SerializeField] int goblinDamage = 20;

    int currentHealth;
    readonly List<IHealthObserver> observers = new List<IHealthObserver>();
    public int CurrentHealth => currentHealth;
    public int MaxHealth => maxHealth;
    public event System.Action<int, int> OnHealthChanged;
    public GameObject goblin;

    void Awake()
    {
        currentHealth = Mathf.Clamp(startingHealth, 0, maxHealth);
    }


    // Start is called before the first frame update
    void Start()
    {
        NotifyObservers();
    }

    public void RegisterObserver(IHealthObserver observer)
    {
        if (observer == null) return;
        if (!observers.Contains(observer)) observers.Add(observer);
        observer.OnHealthChanged(currentHealth, maxHealth);
    }

    void NotifyObservers()
    {
        foreach (var obs in observers)
            obs.OnHealthChanged(currentHealth, maxHealth);

        OnHealthChanged?.Invoke(currentHealth, maxHealth);
    }

    public void TakeDamage(int amount)
    {
        if (amount <= 0) return;

        currentHealth = Mathf.Clamp(currentHealth - amount, 0, maxHealth);
        NotifyObservers();

        if (currentHealth == 0)
            OnDeath();

    }

    void OnDeath()
    {
        SceneManager.LoadScene(1);
    }

    public void OnCollisionrEnter(Collider collider)
    {
        if (collider.gameObject == goblin) return;
        TakeDamage(goblinDamage);
    }

}
