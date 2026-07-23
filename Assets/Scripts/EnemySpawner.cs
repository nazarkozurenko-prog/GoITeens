using UnityEngine;
using NUnit.Framework;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyStats enemyStats;
    [SerializeField] private EnemyStats enemyStats2;
    [SerializeField] private EnemyController enemyPrefab;
    [SerializeField] private List<Transform> spawnPoints;

    private void Start()
    {
        SpawnEnemy();
    }

    private void SpawnEnemy()
    {
        int randomIndex = Random.Range(0, spawnPoints.Count);
        Transform spawnPoint = spawnPoints[randomIndex];
        EnemyController enemy = Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        enemy.Initialize(enemyStats);
    }
}
