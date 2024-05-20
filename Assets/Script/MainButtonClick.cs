using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainButtonClick : MonoBehaviour

{
    public GameObject textBox;
    public AudioSource playSound;
    public GameObject amountObject;
    public TMP_Text amountText;
    public GameObject mainButton;
    public float addCash = 1;
    public float consecutiveClicks = 0;

    private void Update()
    {
        amountText.text = $"+ {addCash}";
    }

    public void ClickTheButton()
    {
        playSound.Play();
        GlobalOnHandCash.OnHandCashCount += addCash;
        consecutiveClicks++;

        float randomX = (mainButton.transform.position.x + Random.Range(-20, 100));
        float randomY = (mainButton.transform.position.y + Random.Range(20, 40));
        //Debug.Log($"rX: {randomX}. rY: {randomY}");

        amountObject.SetActive(false);
        amountObject.transform.position = new Vector3(randomX, randomY , 0);
        amountObject.SetActive(true);
        
        StartCoroutine(Fly());
        
    }

    IEnumerator Fly()
    {
        for (int i = 0; i <= 19; i++)
        {
            yield return new WaitForSeconds(0.01f);

            //amountObject.transform.position = new Vector3(amountObject.transform.position.x, amountObject.transform.position.y, 0);
            //Debug.Log($"X: {amountObject.transform.position.x}. Y: {amountObject.transform.position.y}");
        }

        amountObject.SetActive(false);
    }
    public void ResetConsecutiveClicks()
    {
        consecutiveClicks = 0; 
    }
}
