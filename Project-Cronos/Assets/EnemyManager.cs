using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Transform[] SpawnPoints;
    public GameObject EnemyPrefab;

    [SerializeField] int waveSize;
    [SerializeField] int waveScale;
    [SerializeField] int currentSpawnAmount;


    void Update()
    {
        WaveManager();
    }


    void SpawnNewEnemy()
    {

        int randomNumber = Mathf.RoundToInt(Random.Range(0f, SpawnPoints.Length - 1));

        Instantiate(EnemyPrefab, SpawnPoints[randomNumber].transform.position, Quaternion.identity);
    }

    void WaveManager()
    {
        if (currentSpawnAmount < waveSize)
        {
            SpawnNewEnemy();
            currentSpawnAmount++;
        }
        
    }
}
