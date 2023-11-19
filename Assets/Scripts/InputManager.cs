using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    [SerializeField] private KeyCode[] keys;
    public bool[] buttonsPressed;
    [SerializeField] private Image[] buttonImages;
    public bool buttonHold;
    private void Update()
    {
        if (buttonHold) 
        {
        PressInput(0, keys[0]);
        PressInput(1, keys[1]);
        PressInput(2, keys[2]);
        PressInput(3, keys[3]);
        PressInput(4, keys[4]);
        PressInput(5, keys[5]);
        }
        else { 
        DownInput(0, keys[0]);
        DownInput(1, keys[1]);
        DownInput(2, keys[2]);
        DownInput(3, keys[3]);
        DownInput(4, keys[4]);
        DownInput(5, keys[5]);
        }
    }

    private void PressInput(int index, KeyCode key)
    {
        Color currentColor = buttonImages[index].color;
        if (Input.GetKey(key))
        {
            currentColor.a = 0.5f;
            buttonImages[index].color = currentColor;
            buttonsPressed[index] = true;
        }
        else
        {
            currentColor.a = 1f;
            buttonImages[index].color = currentColor;
            buttonsPressed[index] = false;
        }
    }
    private void DownInput(int index, KeyCode key)
    {
        Color currentColor = buttonImages[index].color;
        if (Input.GetKeyDown(key))
        {
            currentColor.a = 0.5f;
            buttonImages[index].color = currentColor;
            buttonsPressed[index] = true;
        }
        else
        {
            currentColor.a = 1f;
            buttonImages[index].color = currentColor;
            buttonsPressed[index] = false;
        }
    }
}
