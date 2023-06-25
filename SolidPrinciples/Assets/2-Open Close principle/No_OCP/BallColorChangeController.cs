using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColorChangeController : MonoBehaviour
{
    public ItemType itemType;
    public Material blueColorMat, redColorMet, yellowColorMet;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void OnCollisionEnter(Collision collision)
    {
        if (itemType == ItemType.BLUE)
        {
            collision.gameObject.GetComponent<MeshRenderer>().material = blueColorMat;
        }
        else if (itemType == ItemType.RED)
        {
            collision.gameObject.GetComponent<MeshRenderer>().material = redColorMet;

        }
        else if (itemType == ItemType.YELLOW)
        {
            collision.gameObject.GetComponent<MeshRenderer>().material = yellowColorMet;
        }
    }
}
