using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColorRed : BallColorChangeBase
{
    public Material  redMet;
    public override void OnColorChange(GameObject ballGb)
    {
        ballGb.GetComponent<MeshRenderer>().material = redMet;
        // add more logic here according to your need. 
    }


}
