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

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            informationImage.enabled = false;
        }
    }

}
