using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitTutorial : MonoBehaviour
{
    // This method will be called when the QuitTutorial button is clicked
    public void LoadStartMenu()
    {
        // Load the StartMenu scene
        SceneManager.LoadScene("StartMenu");
    }
}
