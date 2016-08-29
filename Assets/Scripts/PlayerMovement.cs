using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	public int speed; // The player's movement speed multiplier

	private Rigidbody playerRB; // The player's rigidbody

	void Start() // Beginning of the first frame
	{
		playerRB = GetComponent<Rigidbody>(); // Returns component of given type if game object has one attached, NULL otherwise
	}

    void FixedUpdate() // For physics-based frame updates
    {
        float moveX = Input.GetAxis("Horizontal");  // Get x-axis input from keyboard (A-D and left-right arrow keys)
        float moveZ = Input.GetAxis("Vertical");    // Get z-axis input from keyboard (W-S and up-down arrow keys)
        Vector3 movement = new Vector3(moveX, 0, moveZ); // Create movement with user inputs
        playerRB.AddForce(movement * speed); // Apply force to the rigidbody using movement vector
    }
}
