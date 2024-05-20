using UnityEngine;
using UnityEngine.UI;

public class DoubleCashUpgrade : MonoBehaviour
{
    public MainButtonClick mainButtonClick;
    public Button doubleCashButton;
    public float upgradeCost = 100;

    void Start()
    {
        doubleCashButton.onClick.AddListener(OnDoubleCashClick);
    }

    void OnDoubleCashClick()
    {
        if (GlobalOnHandCash.OnHandCashCount >= upgradeCost)
        {
            GlobalOnHandCash.OnHandCashCount -= upgradeCost;
            mainButtonClick.addCash *= 2;
            doubleCashButton.interactable = false; 
        }
    }
}
