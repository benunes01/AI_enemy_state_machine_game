using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 movementVector;
    private float speed;
    private Rigidbody body;
    void Start()
    {
        body = GetComponent<Rigidbody>();
        speed = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CalculateMovement()
    {
        movementVector = new Vector3(Input.GetAxis("Horizontal"), body.velocity.y, Input.GetAxis("Vertical"));
        body.velocity = new Vector3(movementVector.x * speed, movementVector.y, movementVector.z * speed);
    }
}
