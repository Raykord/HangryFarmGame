using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerLeft : MonoBehaviour
{
    public GameObject[] animalsPrefabs;
    public float spawnPosX = 20.0f;
    public float spawnRangeZ = 10.0f;

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
		Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(0, spawnRangeZ));
		int animalIndex = Random.Range(0, animalsPrefabs.Length);
        animalsPrefabs[animalIndex].gameObject.transform.rotation = Quaternion.Euler(0, 270, 0);
		Instantiate(animalsPrefabs[animalIndex], spawnPos, animalsPrefabs[animalIndex].gameObject.transform.rotation);
	}
}
