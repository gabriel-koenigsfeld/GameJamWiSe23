using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RagemeterUI : MonoBehaviour
{
    [SerializeField] private PlayerProgress _playerProgress; 
    [SerializeField] private Slider slider; 
    [SerializeField] private TextMeshProUGUI rageText; 
    // Start is called before the first frame update
    void Start()
    {
        float sliderValue = NormalizeHeartValue(_playerProgress.rage);
        if (sliderValue <= 0)
        {
            sliderValue = 0.05f;
        }
        slider.value = sliderValue;

        rageText.text = _playerProgress.rage.ToString();
    }

    static float NormalizeHeartValue(float currentHeartRate)
    {
        float minHeart = 50;
        float maxHeart = 180;

        float normalizedHeart = (currentHeartRate - minHeart) / (maxHeart - minHeart);

        // Ensure the value is between 0 and 1
        normalizedHeart = Mathf.Max(0, Mathf.Min(normalizedHeart, 1));

        return normalizedHeart;
    }
    
}
