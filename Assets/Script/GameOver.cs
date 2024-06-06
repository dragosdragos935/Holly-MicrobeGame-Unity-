using System.Collections; // Importing the System.Collections namespace
using System.Collections.Generic; // Importing the System.Collections.Generic namespace
using UnityEngine; // Importing the UnityEngine namespace
using UnityEngine.SceneManagement; // Importing the UnityEngine.SceneManagement namespace to handle scene management

// Declaring a public class named GameOver that inherits from MonoBehaviour
public class GameOver : MonoBehaviour
{
    // Declaring a public GameObject variable to hold the reference to the game over panel
    public GameObject gameobjectPanel;

    // Start is called before the first frame update
    void Start()
    {
        // This method is intentionally left empty
    }

    // Update is called once per frame
    void Update()
    {
        // Checking if the GameObject with the tag "Player" does not exist in the scene
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            // If the player does not exist, activate the game over panel
            gameobjectPanel.SetActive(true);
        }
    }

    // Method to restart the game by reloading the current scene
    public void Restart()
    {
        // Loading the currently active scene again to restart the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
