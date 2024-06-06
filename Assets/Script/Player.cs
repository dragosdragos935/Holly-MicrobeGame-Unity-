using System.Collections; // Importing the System.Collections namespace
using System.Collections.Generic; // Importing the System.Collections.Generic namespace
using UnityEngine; // Importing the UnityEngine namespace
using UnityEngine.UIElements; // Importing the UnityEngine.UIElements namespace (though it is not used in this script)

// Declaring a public class named Player that inherits from MonoBehaviour
public class Player : MonoBehaviour
{
    // Speed of the player
    public float playerSpeed = 5f;
    // Reference to the Rigidbody2D component
    private Rigidbody2D rb;
    // Vector for player direction
    private Vector2 playerDirection;

    // Start is called before the first frame update
    void Start()
    {
        // Getting the Rigidbody2D component attached to the player game object
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // If the user presses up, directionY will be 1; if down, directionY will be -1
        float directionY = Input.GetAxisRaw("Vertical");
        // Setting the playerDirection vector based on the input
        playerDirection = new Vector2(0, directionY).normalized;
    }

    // FixedUpdate is called at a fixed interval and is used for physics calculations
    private void FixedUpdate()
    {
        // Setting the velocity of the Rigidbody2D to move the player up or down
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
}
