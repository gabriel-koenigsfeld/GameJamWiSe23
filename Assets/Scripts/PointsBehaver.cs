using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsBehaver : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private bool hit;
    public bool driveDown;
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
        
        DestroyObject();

        if (hit) return;

        if (driveDown)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

       
    }

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        hit = true;
        
        if (driveDown)
        {
            _rigidbody2D.gravityScale = 4;
        }
        else
        {
            _rigidbody2D.gravityScale = -4;
        }
        
    }

    void DestroyObject()
    {
        
        if(startTime + 4f < liveTime)
        {

            Destroy(this.gameObject);
        }
    }

}
