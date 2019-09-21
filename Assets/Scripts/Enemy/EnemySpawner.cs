using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject enemyContainer;

    public float interval = 3f;
    public float speedIncreaseInterval = 10f;
    public float duration = 0f;
    public float timeSinceSpawn = 0f;

    private void Start()
    {
        interval += Random.value * 10;
    }

    void Update()
    {
        duration += Time.deltaTime;
        timeSinceSpawn += Time.deltaTime;

        if(duration > speedIncreaseInterval)
        {
            duration = 0;
            IncreaseFrequency();
        }
        if(timeSinceSpawn > interval)
        {
            SpawnEnemy();
            timeSinceSpawn = 0;
        }
    }

    // Randomly speed up spawn frequency
    public void IncreaseFrequency()
    {
        interval -= Random.value;
        interval = Mathf.Clamp(interval, .5f, interval);        
    }

    public void SpawnEnemy()
    {
        var enemy = Instantiate(enemyPrefab, enemyContainer.transform, true);
        enemy.transform.position = new Vector3(transform.position.x, transform.position.y, 0) + Vector3.right * -.17f;
        GetComponent<Animator>().SetTrigger("Restart");

    }
}
