using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GlobalCash globalCash;
    public GameObject BG_Won;
    public GameObject BG_Over;

    private void Start()
    {
        BG_Won.SetActive(false);
        BG_Over.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalCash.CashCount >= 1000000)
        {
            // Show that you won!
            BG_Won.SetActive(true);
        }

        if (GlobalCash.CashCount <= -5000)
        {
            // Show that it is game over
            BG_Over.SetActive(true);
        }
    }

    public void Restart()
    {
        GlobalCash.CashCount = 0;
        GlobalOnHandCash.OnHandCashCount = 0;
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
