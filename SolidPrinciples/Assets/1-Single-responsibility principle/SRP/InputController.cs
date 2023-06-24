using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public MovementVar movementVar;

    void Start()
    {
        movementVar.Reset();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        movementVar.Set(horizontal, 0f, vertical);
    }
}
