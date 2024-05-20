using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsScript : MonoBehaviour
{
    public GameObject settingsContainer;

    public void OnClickToggleSettings()
    {
        settingsContainer.SetActive(!settingsContainer.activeSelf);
    }

    public void OnClickButtons()
    {
        settingsContainer.SetActive(false);
    }
}
