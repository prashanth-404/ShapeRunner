using System.Collections;
using UnityEngine;

public class BossSpawn : MonoBehaviour
{
    // public variables
    public float secondsBetweenSpawning = 0.1f;
    public float xMinRange = -25.0f;
    public float xMaxRange = 25.0f;
    public float yMinRange = 8.0f;
    public float yMaxRange = 25.0f;
    public float zMinRange = -25.0f;
    public float zMaxRange = 25.0f;
    public GameObject[] spawnObjects; // what prefabs to spawn

    private float nextSpawnTime;
    private int ting = 0;
    // Use this for initialization
    void Start()
    {
        // determine when to spawn the next object
        nextSpawnTime = Time.time + secondsBetweenSpawning;
    }

    // Update is called once per frame
    void Update()
    {
        // exit if there is a game manager and the game is over


        // if time to spawn a new game object
        if (Time.time >= nextSpawnTime)
        {
            // Spawn the game object through function below
            MakeThingToSpawn();

            // determine the next time to spawn the object
            nextSpawnTime = Time.time + secondsBetweenSpawning;
        }
    }

    void MakeThingToSpawn()
    {
        Vector3 spawnPosition;

        // get a random position between the specified ranges
        spawnPosition.x = Random.Range(xMinRange, xMaxRange);
        spawnPosition.y = Random.Range(yMinRange, yMaxRange);
        spawnPosition.z = Random.Range(-(zMinRange + (Time.timeSinceLevelLoad * 22)), -(zMaxRange + (Time.timeSinceLevelLoad * 22)));

        // determine which object to spawn
        int objectToSpawn = ting;
        // actually spawn the game object
        GameObject spawnedObject = Instantiate(spawnObjects[objectToSpawn], spawnPosition, transform.rotation) as GameObject;
        spawnedObject.transform.RotateAround(transform.position, transform.up, 180f);
        // make the parent the spawner so hierarchy doesn't get super messy
        spawnedObject.transform.parent = gameObject.transform;
        ting += 1;
    }
}