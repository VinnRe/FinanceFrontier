using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoosterButton : MonoBehaviour
{
    public AudioSource playSound;
    public float boostValue = 500;

    void Start()
    {
        gameObject.SetActive(false); // Make sure the button is initially inactive
    }

    public void OnBoosterClick()
    {
        playSound.Play();
        GlobalOnHandCash.OnHandCashCount += boostValue;
        gameObject.SetActive(false); // Deactivate the button after use
    }
}
