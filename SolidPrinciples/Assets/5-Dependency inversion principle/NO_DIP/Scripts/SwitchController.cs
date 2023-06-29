using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchController : MonoBehaviour
{
    public BlubController blubController;
    public Image powerbuttonImage;
    public Sprite blubOn, blubbOff;
    bool isActive = false;

    public void OnPowerButtonClicked()
    {
        if(!isActive)
        {
            powerbuttonImage.sprite = blubbOff;
            isActive = true;
            blubController.BlubOn();
        }
        else
        {
            powerbuttonImage.sprite = blubOn;
            isActive = false;
            blubController.BlubOff();
        }
    }

  
}
