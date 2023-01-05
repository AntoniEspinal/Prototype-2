using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Spawn random animal at random x position at top of play area
    void SpawnRandomAnimal ()
    {
        Vector3 spawnPosX = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPosX, animalPrefabs[animalIndex].transform.rotation);

        Vector3 spawnLeft = new Vector3(-25, 0, Random.Range(0, 25));
        Instantiate(animalPrefabs[animalIndex], spawnLeft, animalPrefabs[animalIndex].transform.rotation);
    }

}
