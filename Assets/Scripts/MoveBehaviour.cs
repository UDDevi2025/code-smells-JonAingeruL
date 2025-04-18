using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBehaviour : MonoBehaviour
{

    private Rigidbody playerRigidbody;

    public float movementSpeed;
    public float rotationSpeed;

    private void Update()
    {
        foxMovement();
    }

    private void foxMovement()
    {
        playerRigidbody = GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.W))
        {
            // Move forward
            playerRigidbody.MovePosition(transform.position + transform.forward * movementSpeed * Time.deltaTime * 1);
        }

        if (Input.GetKey(KeyCode.S))
        {
            // Move backward
            playerRigidbody.MovePosition(transform.position + transform.forward * movementSpeed * Time.deltaTime * -1);
        }

        if (Input.GetKey(KeyCode.A))
        {
            // Rotate left
            playerRigidbody.MoveRotation(Quaternion.Euler(transform.localRotation.eulerAngles + Vector3.up * rotationSpeed * Time.deltaTime * -1));
        }

        if (Input.GetKey(KeyCode.D))
        {
            // Rotate right
            playerRigidbody.MoveRotation(Quaternion.Euler(transform.localRotation.eulerAngles + Vector3.up * rotationSpeed * Time.deltaTime * 1));
        }
    }
}