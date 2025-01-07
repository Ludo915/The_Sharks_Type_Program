using UnityEngine;
using TMPro;

public class TextColorChanger : MonoBehaviour
{
    public TMP_Text displayText;             // Reference to the TextMeshPro text component
    public TypeManager typeManager;          // Reference to the TypeManager for progress tracking
    public string targetText = "";           // The target text to type

    private void Start()
    {
        // Ensure the targetText is set from DataManager
        targetText = DataManager.Instance.TargetText;
    }

    private void Update()
    {
        if (typeManager == null) return;

        // Get the current number of correctly typed characters from TypeManager
        int correctCharacterCount = typeManager.GetCorrectCharacterCount();

        // Build the text with color-coding
        string coloredText = "";
        for (int i = 0; i < targetText.Length; i++)
        {
            if (i < correctCharacterCount)
            {
                // Correctly typed characters are colored green
                coloredText += $"<color=green>{targetText[i]}</color>";
            }
            else if (i == correctCharacterCount)
            {
                // The current character to type is kept in red as a hint
                coloredText += $"<color=red>{targetText[i]}</color>";
            }
            else
            {
                // Remaining characters are left uncolored (default color)
                coloredText += targetText[i];
            }
        }

        // Update the TextMeshPro component with the colored text
        displayText.text = coloredText;
    }
}
