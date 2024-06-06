using System.Collections; // Importing the System.Collections namespace
using System.Collections.Generic; // Importing the System.Collections.Generic namespace
using UnityEngine; // Importing the UnityEngine namespace

// Declaring a public class named Obstacle that inherits from MonoBehaviour
public class Obstacle : MonoBehaviour
{
    // Declaring a public GameObject variable to hold the reference to the player
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        // Finding and assigning the GameObject with the tag "Player" to the player variable
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // This method is intentionally left empty
    }

    // Method triggered when the GameObject this script is attached to enters a collision with another collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collided object has the tag "Border"
        if (collision.tag == "Border")
        {
            // If it is the border, destroy this game object (the obstacle)
            Destroy(this.gameObject);
        }
        // Otherwise, check if the collided object has the tag "Player"
        else if (collision.tag == "Player")
        {
            // If it is the player, destroy the player game object
            Destroy(player.gameObject);
        }
    }
}
