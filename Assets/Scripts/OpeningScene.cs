using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningScene : MonoBehaviour
{
    [SerializeField] private PlayerProgress _playerProgress;
    [SerializeField] private TextMeshProUGUI dayText;

    private void Awake()
    {
        _playerProgress.level = 0;
        //_playerProgress.rage = 50;
    }

    private void Start()
    {
        _playerProgress.day += 1;
        dayText.text = _playerProgress.day.ToString();
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene(2);
        }
    }
}
