using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    //public int animalIndex;
    private float spawnRangeX = 20;
    private float spawnPositionZ = 29;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    SpawnRandomAnimal();
        //}
    }

    void SpawnRandomAnimal()
    {
        //int animalIndex = Random.Range(0,3);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //Vector3 spawnPosition = new Vector3(Random.Range(-20, 20), 0, 29);
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);
        //Instantiate(animalPrefabs[0], new Vector3(0,0,20) , animalPrefabs[0].transform.rotation);
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}
