using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class GlobalMute : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject realButton;
    public static bool turnOffButton = false;

    void Update()
    {
        realButton.SetActive(true);
        fakeButton.SetActive(false);
        turnOffButton = true;
       
        if (turnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }


    }
}
