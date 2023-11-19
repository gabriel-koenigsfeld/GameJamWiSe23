using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public bool successful;
    public UnityEvent eventOnSuccess;
    public UnityEvent eventOnFail;
    public WinLoseIcons winLoseIcons;
    
    [SerializeField] private float warmUpTime = 3f;
    private float currentWarmUpTime;
    
    public float minigameTime = 8f;
    public float currentMinigameTime;    
    
    [SerializeField] private float postTime = 2f;
    private float currentPostTime;

    [SerializeField] private TextMeshProUGUI warmUpText;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private GameObject timerBG;

    public PlayerProgress playerProgress;

    private void Start()
    {
        playerProgress.timeState = TimeState.WarmUp;
        
        warmUpText.SetText((""));
        timerText.SetText((""));
        timerBG.SetActive(false);
    }

    void Update()
    {
        IncrementWarmUpTime();
        IncrementMinigameTime();
        IncrementPostTime();
        
        if(playerProgress.timeState != TimeState.Minigame && playerProgress.timeState != TimeState.Post) {
            CheckWarmUpTimeOver();
        }
        if(playerProgress.timeState != TimeState.Post) {
            CheckMinigameTimeOver();
        }
        CheckPostTimeOver();
    }
    private void IncrementWarmUpTime()
    {
        if (playerProgress.timeState != TimeState.WarmUp) return;
        
        currentWarmUpTime += Time.deltaTime;
        warmUpText.SetText((Mathf.Ceil(warmUpTime - currentWarmUpTime)).ToString());
    }
    private void IncrementMinigameTime()
    {
        if (playerProgress.timeState != TimeState.Minigame) return;
        
        currentMinigameTime += Time.deltaTime;
        timerText.SetText((Mathf.Ceil(minigameTime - currentMinigameTime)).ToString());
        
    }
    
    private void IncrementPostTime()
    {        
        if (playerProgress.timeState != TimeState.Post) return;

        currentPostTime += Time.deltaTime;
        timerText.SetText("");
        timerBG.SetActive(false);

    }
    

    private void CheckWarmUpTimeOver()
    {
        if (currentWarmUpTime < warmUpTime) return;
        
        playerProgress.timeState = TimeState.Minigame;
        warmUpText.SetText("");
        timerBG.SetActive(true);
    }
    
    private void CheckMinigameTimeOver()
    {
        if (currentMinigameTime < minigameTime) return;
        
        playerProgress.timeState = TimeState.Post;
        timerText.SetText("");
        timerBG.SetActive(false);
        
        if (successful)
        {
            eventOnSuccess.Invoke();
        }
        else
        {
            eventOnFail.Invoke();
        }
    }
    
    private void CheckPostTimeOver()
    {
        if (currentPostTime < postTime) return;

        SceneManager.LoadScene("Scenes/Intermission");
        playerProgress.level += 1;
    }
}

public enum TimeState
{
    WarmUp,
    Minigame,
    Post
}
