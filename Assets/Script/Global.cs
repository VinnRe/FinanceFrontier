using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Global : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public float currentCash;
    public static bool turnOffButton = false;
    public MainButtonClick mainButtonClick;
    public static float UpgradeValue = 1250;

    void Update()
    {
        currentCash = GlobalCash.CashCount;
        fakeText.GetComponent<Text>().text = "x2 Boost - ₱" + UpgradeValue;
        realText.GetComponent<Text>().text = "x2 Boost - ₱" + UpgradeValue;
        if (currentCash >= UpgradeValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (turnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }



    }
}

