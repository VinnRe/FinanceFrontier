using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{
    public static float CashCount;
    public GameObject CashDisplay;
    public float InternalCash;

    void Update()
    {
        InternalCash = CashCount;
        CashDisplay.GetComponent<Text>().text = "Savings: ₱ " + InternalCash;
    }
}
