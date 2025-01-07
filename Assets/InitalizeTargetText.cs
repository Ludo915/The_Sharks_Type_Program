using UnityEngine;
using TMPro;

public class TextInputHandler : MonoBehaviour
{
    public TMP_InputField inputField;       // Reference to the TMP_InputField (for user input)
    public TextMeshProUGUI displayText;     // Reference to the TextMeshProUGUI (to display the input text)
    public TypeManager typeManager;
    void Start()
    {
        // Initialize the TextMeshProUGUI field with existing data, if any
        if (DataManager.Instance != null && !string.IsNullOrEmpty(DataManager.Instance.TargetText))
        {
            displayText.text = DataManager.Instance.TargetText;
            inputField.text = DataManager.Instance.TargetText;
        }
    }

    public void OnSubmitText()
    {
        // Get the text from the InputField and update the DataManager
        if (inputField != null && displayText != null)
        {
            string input = inputField.text;          // Capture the input from the TMP_InputField
            DataManager.Instance.TargetText = input; // Save the text to DataManager

            // Display the text in the TextMeshProUGUI element
            displayText.text = input;
        }
    }
}
