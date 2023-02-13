using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] enemies;
    [SerializeField] GameObject powerup;
    float zUp = 3.80f;
    float zDown = 0f;
    float xRight = 7.5f;
    float xLeft = -7f;
    float startDelay = 1.0f;
    float enemySpawnRate = 1.0f;
    float powerupSpawnRate = 5.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating(nameof(SpawnEnemy), startDelay, enemySpawnRate);
        InvokeRepeating(nameof(SpawnPowerup), startDelay, powerupSpawnRate);
    }

  
    void SpawnEnemy()
    {
        int randomIndex = Random.Range(0, enemies.Length);
        Instantiate(enemies[randomIndex], new Vector3(Random.Range(xLeft, xRight), 0.5179996f, Random.Range(zDown, zUp)), enemies[randomIndex].transform.rotation);
    }
    void SpawnPowerup()
    {
        Instantiate(powerup, new Vector3(Random.Range(xLeft, xRight), 0.4849997f, Random.Range(zDown, zUp)), powerup.transform.rotation);
    }
}
