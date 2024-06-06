using System.Collections; // Importing the System.Collections namespace
using System.Collections.Generic; // Importing the System.Collections.Generic namespace
using UnityEngine; // Importing the UnityEngine namespace

// Declaring a public class named SpawnObstacles that inherits from MonoBehaviour
public class SpawnObstacles : MonoBehaviour
{
    // Public GameObject variable to hold the obstacle prefab
    public GameObject obstacle;
    // Public float variables to define the range within which obstacles will be spawned
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    // Public float variable to control the time interval between spawns
    public float timeBetweenSpawn;
    // Private float variable to keep track of the next spawn time
    private float SpawnTime;

    // Update is called once per frame
    void Update()
    {
        // Check if the current time is greater than the next spawn time
        if (Time.time > SpawnTime)
        {
            // Call the Spawn method to spawn an obstacle
            Spawn();
            // Set the next spawn time
            SpawnTime = Time.time + timeBetweenSpawn;
        }
    }

    // Method to spawn an obstacle at a random position within the defined range
    void Spawn()
    {
        // Generate random X and Y coordinates within the specified range
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        // Instantiate the obstacle at the random position with the same rotation as the spawner
        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
