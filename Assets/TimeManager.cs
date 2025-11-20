using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;


public class TimeManager : MonoBehaviour
{
    public static TimeManager Instance { get; private set; }

    [SerializeField] private float startTime = 120f;

    [Header("UI")]
    [SerializeField] private TextMeshProUGUI timerText;

    private float currentTime;
    private bool isCountingDown = false;
    public event Action OnTimerEnd; 
    public float CurrentTime => currentTime;
    public bool IsCountingDown => isCountingDown;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        ResetTimer();
        UpdateTimerText();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isCountingDown) return;

        currentTime -= Time.deltaTime;
        if (currentTime <= 0)
        {
            currentTime = 0;
            isCountingDown = false;
            OnTimerEnd?.Invoke();
        }
        UpdateTimerText();
    }
    public void StartTimer()
    {
        isCountingDown = true;
    }

    public void StopTimer()
    {
        isCountingDown = false;
    }

    public void ResetTimer()
    {
        currentTime = startTime;
    }

    public void SetTime(float newTime)
    {
        startTime = newTime;
        currentTime = startTime;
        UpdateTimerText();
    }

    private void UpdateTimerText()
    {
        if (timerText == null) return;

        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);
        timerText.text = $"{minutes:00}:{seconds:00} until dungeon collapses!";
    }

}
