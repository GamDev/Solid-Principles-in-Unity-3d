using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowItem : MonoBehaviour,ICollectableItem
{
    public void CollectItem()
    {
        // Add you own logic here, which will depend on your requirments.
        this.gameObject.SetActive(false);
    }


}
