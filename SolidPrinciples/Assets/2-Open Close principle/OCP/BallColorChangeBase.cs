using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BallColorChangeBase : MonoBehaviour
{
   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public abstract void OnColorChange(GameObject ballGb);

    public void OnCollisionEnter(Collision collision)
    {
        OnColorChange(collision.gameObject);
    }
}
