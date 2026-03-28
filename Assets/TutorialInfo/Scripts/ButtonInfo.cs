using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{
    public Image informationImage;
    public bool pause;

    private void Start()
    {
        informationImage.enabled = false;
    }

    public void Informacion() 
    {
        informationImage.enabled=true;

        if (pause)
        {
            pause = false;
            Time.timeScale = 1.0f;
        }
        else
        {
            pause = true;
            Time.timeScale = 0.0f;
        }

        //no lee el input
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            print("1");
            informationImage.enabled=false;
            print("2");

        }
    }

}
