using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public bool enableMovement = true;
    public float initialSpeed;
    public float speedIncreaseFactor;
    public float strafeSpeed;
    public float addedGravity;

    private GameObject player;
    private Rigidbody rb;
    private float currentSpeed;

    private const float DRAG_AFTER_END = 1f;
    private const float ADDED_GRAVITY_AFTER_END = 10f;


    // Start is called before the first frame update
    void Start() {
        player = gameObject;
        rb = player.GetComponent<Rigidbody>();
        currentSpeed = initialSpeed;
    }

    // Update is called once per frame
    void FixedUpdate() {
        if (enableMovement) {
            currentSpeed += speedIncreaseFactor;

            if (Input.GetAxisRaw("Horizontal") < 0) {
                MoveLeft();
            }
            
            if (Input.GetAxisRaw("Horizontal") > 0) {
                MoveRight();
            }
        }
        else {
            // Stop the player from moving forward
            currentSpeed = 0;
            // Set the drag to something more realistic for falling physics
            rb.drag = DRAG_AFTER_END;
            // Set the gravity to something that works will with the updated drag
            addedGravity = ADDED_GRAVITY_AFTER_END;
        }

        // Always moving forward
        MoveForward();
    }

    void MoveLeft() {
        rb.AddForce(-strafeSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    void MoveRight() {
        rb.AddForce(strafeSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    void MoveForward() {
        rb.AddForce(0, -addedGravity * Time.deltaTime, currentSpeed * Time.deltaTime, ForceMode.VelocityChange);
    }
}
