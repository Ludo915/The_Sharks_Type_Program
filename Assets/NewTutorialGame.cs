using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; // Required for TextMeshPro types

public class NewTutorialGame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static void StartTutorial()
    {
        SceneManager.LoadScene("Jungle");   
    }
}
