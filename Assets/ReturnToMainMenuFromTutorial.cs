using UnityEngine;
using UnityEngine.SceneManagement;


public class ReturnToMainMenuFromTutorial : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
