using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlubTurnOnOffController : MonoBehaviour,ITurnable
{
    public Image blubImage;
    public Sprite blubOn, blubbOff;

    public void TurnOn()
    {
        blubImage.sprite = blubOn;
    }

    public void TurnOff()
    {
        blubImage.sprite = blubbOff;
    }
}
