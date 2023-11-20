using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneIntermission : MonoBehaviour
{
    [SerializeField] private PlayerProgress _playerProgress;
    [SerializeField] private int intermissionTime;
    [SerializeField] private TextMeshProUGUI intermissionText;
    void Start()
    {
        StartCoroutine(LoadNextScene());
        SetIntermissionText();
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(intermissionTime);
        
        SceneManager.LoadScene(_playerProgress.level + 2);
    }

    void SetIntermissionText()
    {
        if (_playerProgress.rage >= 150)
        {
            intermissionText.text = "Ich bin so MAD!";
        }

        if (_playerProgress.rage < 150 && _playerProgress.rage >= 120)
        {
            intermissionText.text = "Sauer bin ich ja";
        }
        
        if (_playerProgress.rage < 120 && _playerProgress.rage >= 80)
        {
            intermissionText.text = "leicht genervt.";
        }

        if (_playerProgress.rage >= 80) return;

        intermissionText.text = "Endlich... Frieden.";
    }
}
