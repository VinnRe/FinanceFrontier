using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float cashOnHand;
    public float cashCount;

    // Add more parameters to save here
    public PlayerData(GlobalOnHandCash GOHC, GlobalCash globalCash)
    {
        cashOnHand = GlobalOnHandCash.OnHandCashCount;
        cashCount = GlobalCash.CashCount;
    }

}
