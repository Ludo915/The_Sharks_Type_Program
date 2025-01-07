using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;


[RequireComponent(typeof(RawImage))]
public class FullScreenVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer;  // Reference to the VideoPlayer
    private RawImage rawImage;

    void Start()
    {
        rawImage = GetComponent<RawImage>();
        FitToScreen();
    }

    void FitToScreen()
    {
        // Target aspect ratio
        float targetAspect = 2100f / 900f;

        // Screen aspect ratio
        float screenAspect = (float)Screen.width / Screen.height;

        // Scale and position the RawImage to fit the screen while maintaining the aspect ratio
        if (screenAspect >= targetAspect)
        {
            // Screen is wider than the video aspect, so adjust width
            rawImage.rectTransform.sizeDelta = new Vector2(Screen.height * targetAspect, Screen.height);
        }
        else
        {
            // Screen is taller than the video aspect, so adjust height
            rawImage.rectTransform.sizeDelta = new Vector2(Screen.width, Screen.width / targetAspect);
        }
    }
}
