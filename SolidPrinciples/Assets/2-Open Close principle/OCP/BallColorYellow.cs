using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColorYellow : BallColorChangeBase
{
    public Material yellowMet;

    public override void OnColorChange(GameObject ballGb)
    {
        ballGb.GetComponent<MeshRenderer>().material = yellowMet;
        // add more logic here according to your need. 
    }
}
