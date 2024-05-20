using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostLog : MonoBehaviour
{
    public AudioSource playSound;
    public GameObject BoostCash;
  

    public void PowerCash()
    {
        playSound.Play();
        BoostCash.SetActive(true);

        GlobalBoost.turnOffButton = true;
        //GlobalBoost.boostPerSec += 1;
        //GlobalBoost.numberOfInvestors += 1;
    }
}
