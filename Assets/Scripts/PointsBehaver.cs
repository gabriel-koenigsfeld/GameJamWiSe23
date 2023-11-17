using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsBehaver : MonoBehaviour
{
    public float speed = 5f;
    private float startTime = 0f;
    private float liveTime = 0f;

    private void Start()
    {
        startTime = Time.deltaTime;
        liveTime = Time.deltaTime;
    }
    // Geschwindigkeit der Bewegung nach unten

    void Update()
    {
        liveTime += Time.deltaTime;
        // Bewege das Objekt nach unten basierend auf der Geschwindigkeit und der Zeit zwischen den Frames
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        DestroyObject();
       
    }


    void DestroyObject()
    {
        
        if(startTime + 4f < liveTime)
        {

            Destroy(this.gameObject);
        }
    }

}
