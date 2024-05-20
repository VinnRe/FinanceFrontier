using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalBoost : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public float currentCash;
    public static bool turnOffButton = false;
    public static int requiredClicksForBooster = 30;
    public float requiredClicks;
    public MainButtonClick mainButtonClick;


    void Update()
    {
        requiredClicks = mainButtonClick.consecutiveClicks;
        currentCash = GlobalOnHandCash.OnHandCashCount;
        fakeText.GetComponent<Text>().text = "BOOST" ;
        realText.GetComponent<Text>().text = "BOOST" ;
        /*if (currentCash >= boostValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (turnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }*/

        if (requiredClicks >= requiredClicksForBooster)
        {
            realButton.SetActive(true);
            fakeButton.SetActive(false);
            turnOffButton = true;
        }
        if (requiredClicks <= requiredClicksForBooster)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }


    }
}
