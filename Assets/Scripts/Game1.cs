using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game1 : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    [SerializeField] private PlayerProgress _playerProgress;
    public float rotationSpeed;
    public Transform rotationPoint;
    public InputManager _inputManager;
    public bool standUpStatus; 


    void Update()
    {
        if (_playerProgress.timeState != TimeState.Minigame) return;
        // Berechne die Achse, um die gedreht werden soll (hier Z-Achse)
        Vector3 axis = new Vector3(0, 0, 1);
        if(standUpStatus)
        {
            if (_inputManager.buttonsPressed[3])
            {
                // Rotiere das GameObject um den angegebenen Punkt und Achse basierend auf der Zeit und der Rotationssgeschwindigkeit
                if (Mathf.Abs(transform.rotation.z) < 0.7)
                {
                    Debug.Log(transform.rotation.z);
                    transform.RotateAround(rotationPoint.transform.position, axis, rotationSpeed);
                }
            }
        }
        else
        {
            if (_inputManager.buttonsPressed[3])
            {
                // Rotiere das GameObject um den angegebenen Punkt und Achse basierend auf der Zeit und der Rotationssgeschwindigkeit
                if (transform.rotation.z < 0)
                {
                   
                    transform.RotateAround(rotationPoint.transform.position, axis, rotationSpeed);
                }
            }
        }
            
        
    }
}
