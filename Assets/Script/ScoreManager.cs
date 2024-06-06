using System.Collections; // Importing the System.Collections namespace
using System.Collections.Generic; // Importing the System.Collections.Generic namespace
using UnityEngine; // Importing the UnityEngine namespace
using UnityEngine.UI; // Importing the UnityEngine.UI namespace for UI components

// Declaring a public class named ScoreManager that inherits from MonoBehaviour
public class ScoreManager : MonoBehaviour
{
    // Public Text variable to display the score
    public Text scoreText;
    // Public float variable to keep track of the score
    public float score;

    // Start is called before the first frame update
    void Start()
    {
        // This method is intentionally left empty
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the player game object still exists in the scene
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            // Increment the score over time
            score += 1 * Time.deltaTime;
            // Update the score text to display the current score as an integer
            scoreText.text = ((int)score).ToString();
        }
    }
}
