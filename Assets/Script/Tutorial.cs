using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Add this to handle scene changes

public class Tutorial : MonoBehaviour
{
    public Image tutorialImage; // The UI Image component that will display the tutorial pictures
    public Sprite[] tutorialSprites; // An array to hold the tutorial images
    public string nextSceneName; // The name of the next scene to load

    private int currentImageIndex = 0;

    void Start()
    {
        // Initialize the first image
        if (tutorialSprites.Length > 0)
        {
            tutorialImage.sprite = tutorialSprites[0];
        }
    }

    void Update()
    {
        // Check for mouse click to change the image
        if (Input.GetMouseButtonDown(0))
        {
            ChangeImage();
        }

        // Your existing Update logic (if any)
    }

    void ChangeImage()
    {
        // Increment the image index
        currentImageIndex++;

        // If the index exceeds the array length, load the next scene
        if (currentImageIndex >= tutorialSprites.Length)
        {
            // Load the specified scene
            SceneManager.LoadScene(nextSceneName);
        }
        else
        {
            // Set the new image
            tutorialImage.sprite = tutorialSprites[currentImageIndex];
        }
    }
}
