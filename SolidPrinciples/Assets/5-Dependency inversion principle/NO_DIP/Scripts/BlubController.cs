using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlubController : MonoBehaviour
{
    public Image blubImage;
    public Sprite blubOn, blubbOff;

    public void BlubOn()
    {
        blubImage.sprite = blubOn;
    }

    public void BlubOff()
    {
        blubImage.sprite = blubbOff;
    }
}
