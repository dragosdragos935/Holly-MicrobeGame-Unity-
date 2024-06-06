using System.Collections; // Importing the System.Collections namespace
using System.Collections.Generic; // Importing the System.Collections.Generic namespace
using UnityEngine; // Importing the UnityEngine namespace

// Declaring a public class named CameraMovement that inherits from MonoBehaviour
public class CameraMovement : MonoBehaviour
{
    // Declaring a public float variable to control the speed of the camera
    public float cameraSpeed;

    // Start is called before the first frame update
    void Start()
    {
        // This method is intentionally left empty
    }

    // Update is called once per frame
    void Update()
    {
        // Moving the camera's position horizontally based on cameraSpeed and the time elapsed since the last frame
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
    }
}
