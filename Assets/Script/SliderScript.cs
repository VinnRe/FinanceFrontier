using System.Collections;
using System.Collections.Generic;
using TMPro;    
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public GameObject depositOptions;
    [SerializeField] private Slider _slider;   
    [SerializeField] private TextMeshProUGUI _sliderText;
    [SerializeField] private Button _enterButton;

    public float totalCash = 0f;
    public AudioSource playSound;

    void Awake()
    {
        _slider.onValueChanged.AddListener((v) =>
        {
            _sliderText.text = v.ToString("0.00");
            _slider.maxValue = GlobalOnHandCash.OnHandCashCount;
        });

        _enterButton.onClick.AddListener(OnClickEnterButton);
    }

    void OnClickEnterButton()
    {
        if (depositOptions != null)
        {
            depositOptions.SetActive(false);
        }

        playSound.Play();

        totalCash = float.Parse(_sliderText.text);

        _slider.maxValue = GlobalOnHandCash.OnHandCashCount - totalCash;
        _slider.value = 0;
        _sliderText.text = _slider.value.ToString("0.00");

        GlobalCash.CashCount += totalCash;
        GlobalOnHandCash.OnHandCashCount -= totalCash;
    }
}
