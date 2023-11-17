using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject points;
   

    void Start()
    {
        // Starte die Spawn-Funktion nach dem Start des Spiels
        InvokeRepeating("SpawnPrefab", 0f, 2); // Wiederhole alle 2 Sekunde (0f für sofortigen Start)
    }

    void SpawnPrefab()
    {
        // Spawne das Prefab an einer bestimmten Position (hier: Ursprung)
        Instantiate(points, gameObject.transform.position, Quaternion.identity);
    }
}
