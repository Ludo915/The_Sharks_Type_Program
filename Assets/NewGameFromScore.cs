using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; // Required for TextMeshPro types

public class NewGameFromScore : MonoBehaviour
{
    // Reference to the TextMeshPro InputField (assigned in the Inspector)
    // Key to store player name across scenes
    // Function to start the new game
    public void StartNewGame()
    {
        // Check if the InputField is not null
        // Load the Jungle scene
        SceneManager.LoadScene("Jungle");
        
    }

}
