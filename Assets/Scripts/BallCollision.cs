using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    [HideInInspector]
    public float accelerationFactor = 0.001f;
    public float currentSpeed = 6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Brick"))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            //rb.velocity *= 1.01f;
            rb.velocity = rb.velocity.normalized * currentSpeed;

            //Vector3 normal = collision.contacts[0].normal;

            //// Invert the normal vector to get the opposite direction
            //Vector3 oppositeDirection = -normal;

            //// Calculate the new velocity of the ball
            //Vector3 newVelocity = Vector3.Reflect(transform.forward, oppositeDirection);

            //// Apply the new velocity to the Rigidbody component
            //GetComponent<Rigidbody>().velocity = newVelocity;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Paddle"))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            //rb.velocity *= (1 + accelerationFactor);

            //Vector3 normal = collision.contacts[0].normal;

            //// Invert the normal vector to get the opposite direction
            //Vector3 oppositeDirection = -normal;

            //// Calculate the new velocity of the ball
            //Vector3 newVelocity = Vector3.Reflect(transform.forward, oppositeDirection);

            //// Apply the new velocity to the Rigidbody component
            //GetComponent<Rigidbody>().velocity = newVelocity;
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            //Rigidbody rb = GetComponent<Rigidbody>();
            //rb.velocity *= (1 + accelerationFactor);
        }
    }
}
