using UnityEngine;

public class PlayAudioAccrossScenes : MonoBehaviour
{
    private static PlayAudioAccrossScenes instance2; // Singleton reference

    private void Awake()
    {
        // Check if an instance of the script already exists
        if (instance2 != null && instance2 != this)
        {
            Destroy(gameObject); // Destroy the duplicate instance
            return;
        }

        // Set this instance as the singleton and prevent it from being destroyed on scene load
        instance2 = this;
        DontDestroyOnLoad(gameObject); // Make this object persist across scenes

        // Ensure the audio keeps playing and doesn't stop when switching scenes
        AudioSource audioSource = GetComponent<AudioSource>();
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play(); // Ensure the audio starts playing if it's not already
        }
    }
}
