using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject fallingObjectPrefab;
    public float spawnInterval = 1.0f;

    void Start()
    {
        InvokeRepeating("SpawnObject", 1.0f, spawnInterval);
    }

    void SpawnObject()
    {
        float xPosition = Random.Range(-5.0f, 5.0f);
        Vector3 spawnPosition = new Vector3(xPosition, transform.position.y, 0);
        Instantiate(fallingObjectPrefab, spawnPosition, Quaternion.identity);
    }
}
