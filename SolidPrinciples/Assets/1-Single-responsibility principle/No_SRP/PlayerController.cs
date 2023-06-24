using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;
 
    Vector3 movementVector3;
    public Camera camera;
 
    Vector3 m_Offset;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        m_Offset = camera.transform.position - transform.position; 
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        movementVector3.Set(horizontal, 0f, vertical);

        rb.AddForce(movementVector3 * speed);
    }

    void LateUpdate()
    {
        camera.transform.position = transform.position + m_Offset;
    }
}
