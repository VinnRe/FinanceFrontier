using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCash : MonoBehaviour
{
    public bool CreatingCash = false;
    public static float CashIncrease = 1;
    public float InternalIncrease;

    void Update()
    {
        CashIncrease = GlobalInvestor.investPerSec;
       InternalIncrease =  CashIncrease;
        if (CreatingCash == false)
        {
            CreatingCash = true;
            StartCoroutine(CreateTheCookie());

        }
    }

    IEnumerator CreateTheCookie ()
    {
        GlobalOnHandCash.OnHandCashCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingCash = false ;
    }
}
