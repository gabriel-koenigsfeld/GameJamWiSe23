using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningScene : MonoBehaviour
{
    [SerializeField] private PlayerProgress _playerProgress;

    private void Awake()
    {
        _playerProgress.level = 0;
        _playerProgress.rage = 50;
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene(2);
        }
    }
}
