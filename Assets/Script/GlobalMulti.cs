using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class GlobalMulti : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public float currentCash;
    public static float MultiValue = 210;
    public static bool turnOffButton = false;



    void Start()
    {

    }

    void Update()
    {
        currentCash = GlobalCash.CashCount;
        fakeText.GetComponent<Text>().text = "Multi - ₱" + MultiValue;
        realText.GetComponent<Text>().text = "Multi - ₱" + MultiValue;
        if (currentCash >= MultiValue)
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
