using System.Collections; // Importing the System.Collections namespace
using System.Collections.Generic; // Importing the System.Collections.Generic namespace
using UnityEngine; // Importing the UnityEngine namespace

// Declaring a public class named LoopingBackground that inherits from MonoBehaviour
public class LoopingBackground : MonoBehaviour
{
    // Declaring a public float variable to control the speed of the background movement
    public float backgroundSpeed;
    // Declaring a public Renderer variable to reference the Renderer component of the background
    public Renderer backgroundRenderer;

    // Start is called before the first frame update
    void Start()
    {
        // This method is intentionally left empty
    }

    // Update is called once per frame
    void Update()
    {
        // Moving the background texture by modifying the mainTextureOffset property
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
    }
}
