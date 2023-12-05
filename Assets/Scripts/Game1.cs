using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game1 : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    [SerializeField] private PlayerProgress _playerProgress;
    public int useButton;
    public float rotationSpeed;
    public Transform rotationPoint;
    public InputManager _inputManager;
    public bool standUpStatus;
    public AudioClip[] deineSounds;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void Update()
    {
        if (_playerProgress.timeState != TimeState.Minigame) return;
        // Berechne die Achse, um die gedreht werden soll (hier Z-Achse)
        Vector3 axis = new Vector3(0, 0, 1);
        if(standUpStatus)
        {
            if (_inputManager.buttonsPressed[useButton])
            {
                // Rotiere das GameObject um den angegebenen Punkt und Achse basierend auf der Zeit und der Rotationssgeschwindigkeit
                if (Mathf.Abs(transform.rotation.z) < 0.7)
                {
                    transform.RotateAround(rotationPoint.transform.position, axis, rotationSpeed);
                    RandomSound();
                }
                else
                {
                    _timer.successful = true;
                }
            }
        }
        else
        {
            if (_inputManager.buttonsPressed[useButton])
            {
                // Rotiere das GameObject um den angegebenen Punkt und Achse basierend auf der Zeit und der Rotationssgeschwindigkeit
                if (transform.rotation.z < 0)
                {
                   
                    transform.RotateAround(rotationPoint.transform.position, axis, rotationSpeed);
                    RandomSound();
                }
                else
                {
                    _timer.successful = true;
                }
            }
        }
            
        
    }
    void RandomSound()
    {
        int randomIndex = Random.Range(0, deineSounds.Length);

        // Den ausgewählten Sound abspielen
        audioSource.PlayOneShot(deineSounds[randomIndex]);

    }
}
