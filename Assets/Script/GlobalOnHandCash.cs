using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class GlobalOnHandCash : MonoBehaviour
{
    public static float OnHandCashCount;
    public GameObject onHandCashDisplay;
    public float InternalOnHandCash;

    void Update()
    {
        InternalOnHandCash = OnHandCashCount;
        onHandCashDisplay.GetComponent<Text>().text = "On Hand Money: ₱ " + InternalOnHandCash;
    }
}
