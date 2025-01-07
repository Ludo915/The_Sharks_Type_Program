using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class MoveToNextSceneIntro : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        // Get the VideoPlayer component attached to the same GameObject
        videoPlayer = GetComponent<VideoPlayer>();

        if (videoPlayer != null)
        {
            // Subscribe to the loopPointReached event
            videoPlayer.loopPointReached += OnVideoEnd;
        }
        else
        {
            Debug.LogWarning("VideoPlayer component not found on this GameObject.");
        }
    }

    // This method is called when the video finishes playing
    private void OnVideoEnd(VideoPlayer vp)
    {
        // Load the Jungle scene
        SceneManager.LoadScene("StartMenu");
    }

    private void OnDestroy()
    {
        // Unsubscribe from the event when the object is destroyed to avoid memory leaks
        if (videoPlayer != null)
        {
            videoPlayer.loopPointReached -= OnVideoEnd;
        }
    }
}
