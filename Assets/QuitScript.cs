using UnityEngine;

public class QuitScript : MonoBehaviour
{
    // This method will be called when the Quit button is clicked
    public void QuitGame()
    {
        // Log a message in the console to confirm the button click in the editor
        Debug.Log("Quit button clicked - exiting game.");

        // Exit the application
        Application.Quit();

        // In the Unity editor, Application.Quit() doesn't stop play mode, 
        // so we use this line to exit play mode in the editor
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}

