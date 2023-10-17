using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    // Rigidbody of the player.
    private Rigidbody rb;

    // Movement along X and Y axes.
    private float movementX;
    private float movementY;
    private Vector3 customGravity = new Vector3(0, 0, -9.81f);


    // Speed at which the player moves.
    public float LeftandRightForce = 10f;
    public int force = 2;

    // Start is called before the first frame update.
    void Start()
    {
        // Get and store the Rigidbody component attached to the player.
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    // This function is called when a move input is detected.
    void OnMove(InputValue movementValue)
    {
        // Convert the input value into a Vector2 for movement.
        Vector2 movementVector = movementValue.Get<Vector2>();

        // Store the X and Y components of the movement.
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    // FixedUpdate is called once per fixed frame-rate frame.
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(transform.forward * force,ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-transform.right * LeftandRightForce);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(transform.right * LeftandRightForce);
        }
        rb.AddForce(customGravity * rb.mass); 
    }


        void OnTriggerEnter(Collider other)
        {
            // Check if the object the player collided with has the "PickUp" tag.
            if (other.gameObject.CompareTag("PickUp"))
            {
                // Deactivate the collided object (making it disappear).
                other.gameObject.SetActive(false);
            }
        }

    }




