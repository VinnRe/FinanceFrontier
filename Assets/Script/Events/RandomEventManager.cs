using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomEventManager : MonoBehaviour
{
    public bool isNowEvent = false;
    //private bool buttonClicked = false;
    //public GameObject eventButton;
    public GameObject eventContainer;
    public TMP_Text eventText;
    private MainButtonClick mainButtonClick;
    private GlobalOnHandCash GOHC;
    private GlobalCash globalCash;
    private float originalCashAdder;
    private Coroutine eventCoroutine;
    private float randomCash;
    private float randomTax;
    //private float minimumCashRequired = 500; // To set everything to run 

    // Set List of events
    private List<System.Action> events;

    // Start is called before the first frame update
    void Start()
    {
        // Find the GameObject with the MainButtonClick component
        GameObject mainButton = GameObject.Find("MainButtonClick");
        GameObject globalCashOnHand = GameObject.Find("MechanicsObject");

        // Get the MainButtonClick component from the GameObject
        if (mainButton != null)
        {
            mainButtonClick = mainButton.GetComponent<MainButtonClick>();
        }

        if (globalCashOnHand != null)
        {
            GOHC = globalCashOnHand.GetComponent<GlobalOnHandCash>();
        }

        originalCashAdder = mainButtonClick.addCash;

        // Initialize the events list
        events = new List<System.Action>
        {
            MarketBoom,
            StockRise,
            GovernmentGrant,
            MarketCrash,
            TaxAudit,
            PropertyDestroyed,
            MysteryBox
        };
        eventContainer.SetActive(false);
        StartCoroutine(WaitForEvent());
    }

    // Update is called once per frame
    void Update()
    {
        if (!isNowEvent && eventContainer.activeSelf)
        {
            eventContainer.SetActive(false);
        }

        if (isNowEvent && !eventContainer.activeSelf)
        {
            eventContainer.SetActive(true);
        }
    }

    IEnumerator WaitForEvent()
    {
        while (true)
        {
            yield return new WaitForSeconds(30f); // Can be Changed to how long before an event pops

            if (!isNowEvent) // Check if no event is currently active
            {
                int x = Random.Range(1, 3); // Can be 1 or 2 50% chance

                if (x == 2)
                {
                    isNowEvent = true;
                    RandomEventChooser();
                }
            }
        }
    }

    IEnumerator EventDuration()
    {
        yield return new WaitForSeconds(15f); // Default should be 15 Seconds. This is for CHANGING the seconds of the event
        isNowEvent = false;
        eventContainer.SetActive(false);
        ResetCashAddingToOriginal();
        Debug.Log("Event done.");
    }

    public void RandomEventChooser()
    {
        if (eventCoroutine != null)
        {
            StopCoroutine(eventCoroutine);
        }

        int randomEventIndex = Random.Range(0, events.Count);
        System.Action chosenEvent = events[randomEventIndex];

        if (chosenEvent == PropertyDestroyed && GlobalOnHandCash.OnHandCashCount <= 5000)
        {
            randomEventIndex = Random.Range(0, events.Count);
            chosenEvent = events[randomEventIndex];
        }

        chosenEvent.Invoke();

        isNowEvent = true;
        eventCoroutine = StartCoroutine(EventDuration());
    }

    // RANDOM EVENTS HERE
    // Positive Events
    public void MarketBoom()
    {
        mainButtonClick.addCash *= 2;
        // Add something that will show the event
        eventText.text = $"Market Boom event triggered. Cash doubled.";
        //Debug.Log("Market Boom event triggered. Cash doubled.");
    }

    public void StockRise()
    {
        mainButtonClick.addCash *= 1.5f;
        eventText.text = "Stock prices went up by 150%!. Cash is multiplied by 1.5";
        //Debug.Log("Stock prices went up by 150%!. Cash is multiplied by 1.5");
    }

    public void GovernmentGrant()
    {
        GlobalOnHandCash.OnHandCashCount += 500;
        eventText.text = "Government Grant event triggered. P500 added to on-hand cash.";
        //Debug.Log("Government Grant event triggered. P5000 added to on-hand cash.");
    }

    // Negative Events
    public void MarketCrash()
    {
        mainButtonClick.addCash *= 0.5f;
        // Add something that will show the event
        eventText.text = "Market Crash event triggered. Cash halved.";
        //Debug.Log("Market Crash event triggered. Cash halved.");
    }

    public void TaxAudit()
    {
        randomTax = Random.Range(200, 1000);
        GlobalOnHandCash.OnHandCashCount -= randomTax;
        eventText.text = $"Tax Audit event triggered. -P{randomTax}";
        //Debug.Log($"Tax Audit event triggered. -P{randomTax}");
    }

    public void PropertyDestroyed()
    {
        GlobalOnHandCash.OnHandCashCount -= 5000;
        eventText.text = $"Property Destroyed event triggered. -P5000";
        //Debug.Log($"Property Destroyed event triggered. -P5000");
    }

    // Special Events
    public void MysteryBox()
    {
        randomCash = Random.Range(100, 10000);
        GlobalOnHandCash.OnHandCashCount += randomCash;
        eventText.text = $"MysteryBox event triggered. +P{randomCash}";
        //Debug.Log($"MysteryBox event triggered. +P{randomCash}");
    }

    public void ResetCashAddingToOriginal()
    {
        mainButtonClick.addCash = originalCashAdder;
    }
}
