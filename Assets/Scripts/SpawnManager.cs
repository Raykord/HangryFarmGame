using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalsPrefabs;
    public float spawnPosZ = 20.0f;
    public float spawnRangeX = 20.0f;

    private float startDelay = 2.0f;
    private float spawnInterval = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
		InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
	}

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void SpawnRandomAnimal()
    {
		Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
		int animalIndex = Random.Range(0, animalsPrefabs.Length);
		animalsPrefabs[animalIndex].gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
		Instantiate(animalsPrefabs[animalIndex], spawnPos, animalsPrefabs[animalIndex].gameObject.transform.rotation);
	}
}
