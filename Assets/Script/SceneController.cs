using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("SampleScene");

    }
    public void ChangeScene11()
    {
        SceneManager.LoadScene("Tutorial");

    }
    public void ChangeScene12()
    {
        SceneManager.LoadScene("Main Menu");

    }
}
