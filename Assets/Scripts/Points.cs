using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public GameObject points;
    public float spawnInterval = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPrefab", 0f, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(points, Vector3.zero, Quaternion.identity);
    }
}
