using UnityEngine;
using UnityEngine.SceneManagement;

public class Rankings : MonoBehaviour
{
    // This method will be called when the HighScore button is clicked
    public void LoadRankingScene()
    {
        // Load the Ranking scene
        SceneManager.LoadScene("Ranking");
    }
}

