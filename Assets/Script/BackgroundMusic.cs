using System.Collections; // Importing the System.Collections namespace
using System.Collections.Generic; // Importing the System.Collections.Generic namespace
using UnityEngine; // Importing the UnityEngine namespace

// Declaring a public class named BackgroundMusic that inherits from MonoBehaviour
public class BackgroundMusic : MonoBehaviour
{
    // Declaring a private static variable of type BackgroundMusic
    private static BackgroundMusic backgroundMusic;

    // The Awake method is called when the script instance is being loaded
    private void Awake()
    {
        // Check if the backgroundMusic instance is null
        if (backgroundMusic == null)
        {
            // If it is null, assign the current instance to backgroundMusic
            backgroundMusic = this;
            // Make sure this game object is not destroyed when loading a new scene
            DontDestroyOnLoad(backgroundMusic);
        }
        else
        {
            // If backgroundMusic is not null, it means another instance already exists, so destroy this game object
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // This method is intentionally left empty
    }

    // Update is called once per frame
    void Update()
    {
        // This method is intentionally left empty
    }
}
