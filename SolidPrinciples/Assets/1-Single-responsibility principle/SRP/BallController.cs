using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public MovementVar movementVar;
    private Rigidbody rb;
    public float speed;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        rb.AddForce(movementVar.movementVector * speed);
    }
}
