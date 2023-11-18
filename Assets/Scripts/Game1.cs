using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game1 : MonoBehaviour
{
    public float rotationSpeed = 10f;
    public Transform rotationPoint;


    void Update()
    {
        // Berechne die Achse, um die gedreht werden soll (hier Z-Achse)
        Vector3 axis = new Vector3(0, 0, 1);
        if (Input.GetKeyDown(KeyCode.A))
        {
            // Rotiere das GameObject um den angegebenen Punkt und Achse basierend auf der Zeit und der Rotationssgeschwindigkeit
            transform.RotateAround(rotationPoint.transform.position, axis, -rotationSpeed * Time.deltaTime);
        }
        
    }
}
