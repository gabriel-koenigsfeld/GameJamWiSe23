using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private PlayerProgress _playerProgress;
    public GameObject points;

    public float currentTime;

    public int timeUntilNextSpawn;

    public int[] spawnRange;

    void Start()
    {
        RandomTimeUntilNextSpawn();
    }

    private void Update()
    {
        if (_playerProgress.timeState != TimeState.Minigame) return;
        
        currentTime += Time.deltaTime;
        if (currentTime > timeUntilNextSpawn)
        {
            SpawnPrefab();
            RandomTimeUntilNextSpawn();
            currentTime = 0;
        }
    }

    void SpawnPrefab()
    {
        // Spawne das Prefab an einer bestimmten Position (hier: Ursprung)
        Instantiate(points, gameObject.transform.position, Quaternion.identity);
    }

    void RandomTimeUntilNextSpawn()
    {
        timeUntilNextSpawn = Random.Range(spawnRange[0], spawnRange[1]);
    }
}
