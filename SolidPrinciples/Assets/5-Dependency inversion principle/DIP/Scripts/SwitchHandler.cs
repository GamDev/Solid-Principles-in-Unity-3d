//using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchHandler : MonoBehaviour
{
     ITurnable iturnable;
    public Image powerbuttonImage;
    public Sprite blubOn, blubbOff;
    bool isActive = false;
   
    public void Start()
    {
        iturnable = GameObject.Find("BlubOnOffController").GetComponent<ITurnable>();
    
    }

    public void OnPowerButtonClicked()
    {
        if(!isActive)
        {
            powerbuttonImage.sprite = blubbOff;
            isActive = true;
            iturnable.TurnOn();
        }
        else
        {
            powerbuttonImage.sprite = blubOn;
            isActive = false;
            iturnable.TurnOff();
        }
    }

  
}
