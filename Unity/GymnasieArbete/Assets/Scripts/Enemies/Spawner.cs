using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float SpawnTime;
    public float SpawnDelay = 2f;
    public int EnemiesToSpawn = 1;
    public int wave = 1;
    public GameObject EnemyPrefab;
    public EnemyHealth hp;
    public EnemyMovement em;
    public Currencymanager cm; 
    private void Start()
    {
        em = GetComponent<EnemyMovement>();
        //wm = GameObject.Find("WaveManager").GetComponent<WaveManagement>();

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
            wave += 1;
            EnemiesToSpawn = 10;
            em.MovementSpeed += 0.1f;
        }
    }

    private void EnemySpawn1()
    {
        EnemyHealth enemy1 = Instantiate(EnemyPrefab).GetComponent<LVL1>();
        enemy1.transform.position = transform.position;

    }
    private void EnemySpawn2()
    {
        EnemyHealth enemy2 = Instantiate(EnemyPrefab).GetComponent<LVL2>();
        enemy2.transform.position = transform.position;
    }
    private void EnemySpawn3()
    {
        EnemyHealth enemy3 = Instantiate(EnemyPrefab).GetComponent<LVL3>();
        enemy3.transform.position = transform.position;
        
    }
    private void EnemySpawn4()
    {
        EnemyHealth enemy4 = Instantiate(EnemyPrefab).GetComponent<LVL4>();
        enemy4.transform.position = transform.position;
    }
}
