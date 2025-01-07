using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTutorialScene : MonoBehaviour
{
    // This method will be called when the HighScore button is clicked
    public void LoadTutorial()
    {
        // Load the Ranking scene
        if (DataManager.Instance.Name != null)
        {
            SceneManager.LoadScene("TutorialStartMenu");
        }
    }
}