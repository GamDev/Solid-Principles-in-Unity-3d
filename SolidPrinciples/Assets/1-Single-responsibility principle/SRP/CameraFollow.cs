using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform ballTranfrom;
    Vector3 offset;

   
    void Start()
    {
        offset = this.transform.position - ballTranfrom.position;    
    }

    void LateUpdate()
    {
        this.transform.position = ballTranfrom.position + offset;
    }
}
