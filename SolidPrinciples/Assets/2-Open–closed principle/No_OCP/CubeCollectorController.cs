using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    RED,
    YELLOW,
    BLUE
}

public class CubeCollectorController : MonoBehaviour
{
    public ItemType itemType;

    public void OnCollisionEnter(Collision collision)
    {
        if(itemType == ItemType.BLUE)
        {
            this.gameObject.SetActive(false);
        }
        else if(itemType == ItemType.YELLOW)
        {
            this.gameObject.SetActive(false);

        }
        else if(itemType == ItemType.RED)
        {
            this.gameObject.SetActive(false);

        }
    }
}
