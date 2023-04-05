using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float maxSpeed = 10f;
    public float deceleration = 0.1f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        // Topun hızını düzenle
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }

        // Topun hızını azalt
        if (rb.velocity.magnitude > 0f)
        {
            rb.velocity -= rb.velocity.normalized * deceleration;
        }
    }
}
