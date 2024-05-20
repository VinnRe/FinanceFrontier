using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoCookie;
    public GameObject statusBox;
    public AudioSource playSound;
    public float boostValue = 500;
    public MainButtonClick mainButtonClick; 

    void Start()
    {
        if (mainButtonClick == null)
        {
            
            mainButtonClick = GameObject.FindObjectOfType<MainButtonClick>();
        }
    }

    public void StartAutoCookie()
    {
        if (statusBox != null)
        {
            statusBox.SetActive(true);
        }

        playSound.Play();
        AutoCookie.SetActive(true);
        GlobalCash.CashCount -= GlobalInvestor.investorValue;
        GlobalInvestor.investorValue *= 2;
        GlobalInvestor.turnOffButton = true;
        GlobalInvestor.investPerSec += 1;
        GlobalInvestor.numberOfInvestors += 1;
    }

    public void OnBoosterClick()
    {
        if (mainButtonClick != null)
        {
            playSound.Play();
            GlobalOnHandCash.OnHandCashCount += boostValue;
            GlobalBoost.requiredClicksForBooster *= 2;
            GlobalBoost.turnOffButton = true;
            mainButtonClick.ResetConsecutiveClicks();
        }
    }
    public void UpgradeClick()
    {

        playSound.Play();
        GlobalCash.CashCount -= Global.UpgradeValue;
        Global.UpgradeValue *= 2;
        Global.turnOffButton = true;
        GlobalOnHandCash.OnHandCashCount *= 2 ;
        
        
       
    }
    public void MultiClick()
    {

        playSound.Play();
        GlobalCash.CashCount -= GlobalMulti.MultiValue;
        GlobalMulti.MultiValue *= 3;
        GlobalMulti.turnOffButton = true;
        GlobalOnHandCash.OnHandCashCount *= 3;



    }





}
