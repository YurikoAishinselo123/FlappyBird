using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;  
    public float spawnRate = 3f;   
    public float minY = 4f;       // Minimum Y position for the pipe
    public float maxY = 2f;        // Maximum Y position for the pipe

    private void Start()
    {
        InvokeRepeating("SpawnPipe", 1f, spawnRate);  // Start spawning pipes after 1 second, and then repeatedly
    }

    void SpawnPipe()
    {
        float randomY = Random.Range(minY, maxY);  // Generate random Y position for pipes
        Vector3 spawnPosition = new Vector3(transform.position.x, randomY, 0);  // Pipe position

        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);  // Create the pipe
    }
}
