using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColorBlue : BallColorChangeBase
{
    public Material blueMat;

    public override void OnColorChange(GameObject ballGb)
    {
        ballGb.GetComponent<MeshRenderer>().material = blueMat;
        // add more logic here according to your need. 
    }
}
