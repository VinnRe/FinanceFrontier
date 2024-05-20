using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class GlobalInvestor : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public float currentCash;
    public static float investorValue = 10;
    public static bool turnOffButton = false;
    public GameObject investorStats;
    public static int numberOfInvestors;
    public static float investPerSec;

    void Start()
    {
        
    }

    void Update()
    {
        currentCash = GlobalCash.CashCount;
        investorStats.GetComponent<Text>().text = "Investment Earnings: " + numberOfInvestors + " @ ₱" + investPerSec + " Per Second";
        fakeText.GetComponent<Text>().text = "Invest - ₱" + investorValue;
        realText.GetComponent<Text>().text = "Invest - ₱" + investorValue;
        if (currentCash >= investorValue) {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if(turnOffButton == true) {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
}
