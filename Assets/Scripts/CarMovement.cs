using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField] private InputManager _inputManager;
    
    public float moveSpeed = 5f; // Speed of movement
    public float minX = -3f; // Minimum X position
    public float maxX = 3f; // Maximum X position
    
    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = transform.position;
        if (_inputManager.buttonsPressed[3])
        {
            Debug.Log("left");
            float newPosition = currentPosition.x - moveSpeed * Time.deltaTime;
            newPosition = Mathf.Clamp(newPosition, minX, maxX);
            transform.position = new Vector3(newPosition, currentPosition.y, currentPosition.z);

        }
        if (_inputManager.buttonsPressed[5])
        {
            Debug.Log("right");
            float newPosition = currentPosition.x + moveSpeed * Time.deltaTime;
            newPosition = Mathf.Clamp(newPosition, minX, maxX);
            transform.position = new Vector3(newPosition, currentPosition.y, currentPosition.z);
        }
        
    }
}
