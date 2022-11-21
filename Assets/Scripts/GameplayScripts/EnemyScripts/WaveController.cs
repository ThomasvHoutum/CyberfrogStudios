using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    Vector3 enemyPosTest = new Vector3(-1.86f, 1.35f, 6.45f);
    [SerializeField] Transform enemyRotation;

    int waveNumber;

    bool spawn;
    float timer = 2;
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Enemy").Length <= 0)
        {
            SpawnEnemy();
            waveNumber++;
        }
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            timer = 2;
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, enemyPosTest, enemyRotation.rotation);
    }
}