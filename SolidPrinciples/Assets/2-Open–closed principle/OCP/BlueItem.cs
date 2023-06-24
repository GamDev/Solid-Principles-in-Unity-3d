using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueItem : MonoBehaviour,ICollectableItem
{
    public void CollectItem()
    {
        Debug.Log(" Blue Cube Collected");
        // Add you own logic here, which will depend on your requirments.
        this.gameObject.SetActive(false);
    }


}
