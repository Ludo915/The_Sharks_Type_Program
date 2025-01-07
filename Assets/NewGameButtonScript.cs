using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; // Required for TextMeshPro types

public class NewGameButtonScript : MonoBehaviour
{
    // Reference to the TextMeshPro InputField (assigned in the Inspector)
    public TMP_InputField playerNameInput;
    // Key to store player name across scenes
    public DataManager dataManager;
    // Function to start the new game
    public void StartNewGame()
    {
        // Check if the InputField is not null
        // Load the Jungle scene
        if ((dataManager.Name != null) | (DataManager.Instance.Name != null))
        {
            SceneManager.LoadScene("Sea");
        }
        
    }

}
