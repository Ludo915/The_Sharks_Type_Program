using UnityEngine;
using UnityEngine.UI;

public class RemoveWhiteBackground : MonoBehaviour
{
    public Image MistakeImage;

    private void Start()
    {
        if (MistakeImage != null)
        {
            RemoveWhiteBackgroundFromImage();
        }
    }

    private void RemoveWhiteBackgroundFromImage()
    {
        // Get the texture from the MistakeImage's sprite
        Texture2D texture = MistakeImage.sprite.texture;

        // Check if the texture is readable
        if (!texture.isReadable)
        {
            Debug.LogError("Texture is not readable. Please enable 'Read/Write Enabled' in the texture import settings.");
            return;
        }

        // Make a copy of the texture so we can modify it
        Texture2D newTexture = new Texture2D(texture.width, texture.height, texture.format, false);
        Color[] pixels = texture.GetPixels();

        // Loop through each pixel and change white pixels to transparent
        for (int i = 0; i < pixels.Length; i++)
        {
            // Check if the pixel is white (or close to white)
            if (IsWhite(pixels[i]))
            {
                pixels[i] = new Color(1f, 1f, 1f, 0f); // Set the white pixel to transparent
            }
        }

        // Apply the modified pixels to the new texture
        newTexture.SetPixels(pixels);
        newTexture.Apply();

        // Apply the new texture to the image
        MistakeImage.sprite = Sprite.Create(newTexture, MistakeImage.sprite.rect, new Vector2(0.5f, 0.5f));

        // Optionally, you can also set the material to use a shader that supports transparency if needed
    }

    private bool IsWhite(Color color)
    {
        // Define what is considered "white". This is a tolerance range to account for off-white shades.
        return color.r >= 0.9f && color.g >= 0.9f && color.b >= 0.9f;
    }
}
