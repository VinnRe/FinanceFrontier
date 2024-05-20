using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadManager : MonoBehaviour
{
    public GlobalOnHandCash GOHC;
    public GlobalCash globalCash;

    public void SavePlayer()
    {
        // Add more parameters to save here
        SaveSystem.SavePlayer(GOHC, globalCash);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        GlobalOnHandCash.OnHandCashCount = data.cashOnHand;
        GlobalCash.CashCount = data.cashCount;
    }
}
