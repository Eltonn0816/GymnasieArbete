using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float SpawnTime;
    public float SpawnDelay = 2f;
    public int EnemiesToSpawn = 1;
    public int wave = 1;
    public GameObject EnemyPrefab1;
    public GameObject EnemyPrefab2;
    public GameObject EnemyPrefab3;
    public GameObject EnemyPrefab4;
    public EnemyHealth hp;
    public EnemyMovement em;
    public Vector3 spawnposition;
    public GameObject roundbutton;
    public bool start = false; 

    private void Start()
    {
      roundbutton.SetActive(false);
    }
    public void startround()
    {
        start = true;
        roundbutton.SetActive(false);
        start = false;
    }
    void Update()
    {
        SpawnTime -= Time.deltaTime;
        int RandomizeEnemy = Random.Range(1, 5); //Generates 1-4 randomly
        if (SpawnTime <= 0 && EnemiesToSpawn >= 1 && RandomizeEnemy == 1)
        {
            EnemiesToSpawn -= 1;
            SpawnTime = SpawnDelay;
            EnemySpawn1();
        }

        else if (SpawnTime <= 0 && EnemiesToSpawn >= 1 && RandomizeEnemy == 2)
        {
            EnemiesToSpawn -= 1;
            SpawnTime = SpawnDelay;
            EnemySpawn2();
        }
        else if (SpawnTime <= 0 && EnemiesToSpawn >= 1 && RandomizeEnemy == 3)
        {
            EnemiesToSpawn -= 1;
            SpawnTime = SpawnDelay;
            EnemySpawn3();
        }
        else if (SpawnTime <= 0 && EnemiesToSpawn >= 1 && RandomizeEnemy == 4)
        {
            EnemiesToSpawn -= 1;
            SpawnTime = SpawnDelay;
            EnemySpawn4();
        }
        
        else if (SpawnTime <= 0 && EnemiesToSpawn <= 0)
        {
            roundbutton.SetActive(true);
            if (start == true)
            {
                wave += 1;
                EnemiesToSpawn = 10 + wave;
            } 
        }

    }
    public void EnemySpawn1()
    {
        spawnposition = gameObject.transform.position;
        Instantiate(EnemyPrefab1, spawnposition, Quaternion.identity); 
    }
    public void EnemySpawn2()
    {
        spawnposition = gameObject.transform.position;
        Instantiate(EnemyPrefab2, spawnposition, Quaternion.identity);
    }
    public void EnemySpawn3()
    {
        spawnposition = gameObject.transform.position;
        Instantiate(EnemyPrefab3, spawnposition, Quaternion.identity);
    }
    public void EnemySpawn4()
    {
        spawnposition = gameObject.transform.position;
        Instantiate(EnemyPrefab4, spawnposition, Quaternion.identity);
    }
}
