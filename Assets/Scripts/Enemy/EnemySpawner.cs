using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject enemyContainer;

    public void SpawnEnemy()
    {
        Instantiate(enemyPrefab, enemyContainer.transform, false);
    }
}
