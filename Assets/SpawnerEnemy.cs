using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    [SerializeField] float spawnRange = 15f;

    public GameObject[] enemies; 
    void Start()
    {
        StartCoroutine(SpawnEnemy());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnEnemy( )
    {
        Vector2 spawnPos = GameObject.Find("Player").transform.position;
        spawnPos += Random.insideUnitCircle.normalized * spawnRange;

        Instantiate(enemies[Random.Range(0,enemies.Length)], spawnPos, Quaternion.identity); 

        yield return new WaitForSeconds(1.5f);
        StartCoroutine(SpawnEnemy()); 
    }
}
