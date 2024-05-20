using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class BackgroundMusic : MonoBehaviour
{
    public AudioSource playSound;
    public void MuteHandler(bool unmute)
    {
        if (unmute)
        {
            playSound.Play();
            AudioListener.volume = 1;
        }
        else
        {
            
            AudioListener.volume = 0;
        }
    }


}
