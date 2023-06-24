using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollisionController : MonoBehaviour
{
 
    public void OnCollisionEnter(Collision collision)
    {
        ICollectableItem iCollectableItem = collision.gameObject.GetComponent<ICollectableItem>();
        iCollectableItem?.CollectItem();
    }
}
