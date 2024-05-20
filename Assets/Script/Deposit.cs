using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deposit : MonoBehaviour

{
    public GameObject statusBox;
    public GameObject depositOptions;
    public GameObject fullDeposit;
    public GameObject halfDeposit;
    public GameObject inputDeposit;
    public GameObject slider;

    public AudioSource playSound;
    public float totalCash = 0f;

    void Start()
    {
        if (depositOptions != null)
        {
            depositOptions.SetActive(false);
        }

        if (slider != null)
        {
            slider.SetActive(false);
        }
    }

    public void ClickExitButton()
    {
        if (depositOptions != null)
        {
            depositOptions.SetActive(false);
        }
    }

    public void ClickTheButton()
    {

        if (GlobalOnHandCash.OnHandCashCount == 0)
        {
            statusBox.GetComponent<Text>().text = "Not Enough Money to Deposit.";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else
        {
            if (depositOptions != null)
            {
                depositOptions.SetActive(true);
            }
        }
        
    }

    public void ClickFullDeposit()
    {
        if (depositOptions != null)
        {
            depositOptions.SetActive(false);
        }

        playSound.Play();
        totalCash = GlobalOnHandCash.OnHandCashCount;
        GlobalCash.CashCount += totalCash;
        GlobalOnHandCash.OnHandCashCount = 0;
    }

    public void ClickHalfDeposit()
    {
        if (depositOptions != null)
        {
            depositOptions.SetActive(false);
        }

        playSound.Play();
        totalCash = GlobalOnHandCash.OnHandCashCount / 2f;
        GlobalCash.CashCount += totalCash;
        GlobalOnHandCash.OnHandCashCount /= 2f;
    }

    public void ClickInputDeposit()
    {
        if (slider != null)
        {
            slider.SetActive(true); 
        }

        if (inputDeposit != null)
        {
            inputDeposit.SetActive(false);
        }
    }
}
