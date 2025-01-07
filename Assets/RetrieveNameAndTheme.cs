using UnityEngine;
using TMPro;

public class RetrieveNameAndTheme : MonoBehaviour
{
    public string playerName;

    // References to TMP Input Fields for Name and Theme
    public TMP_InputField nameInputField;
    public TMP_InputField themeInputField;

    // Reference for the popup text or alert message
    public GameObject popupMessage;

    // Automatically find DataManager if it's not assigned
    private DataManager dataManager;

    private void Awake()
    {
        // Find DataManager if not assigned
        if (dataManager == null)
        {
            dataManager = FindObjectOfType<DataManager>();
            if (dataManager == null)
            {
                Debug.LogError("DataManager not found. Ensure a DataManager exists in the scene.");
            }
        }
    }

    // Method to retrieve and store data in DataManager
    public void RetrieveAndStoreData()
    {
        if (dataManager == null)
        {
            Debug.LogWarning("DataManager reference is missing!");
            return;
        }

        // Check if Name InputField has text
        if (!string.IsNullOrEmpty(nameInputField.text))
        {
            playerName = nameInputField.text;  // Use the entered name
        }
        else if (string.IsNullOrEmpty(dataManager.Name))
        {
            ShowPopup("Please enter your name..."); // Prompt for name if no prior data
            return;
        }
        else
        {
            playerName = dataManager.Name;  // Use stored name if no new name entered
            ShowPopup(playerName + " plays again!");
        }

        // Store the values in the DataManager
        dataManager.Name = playerName;

        // Optionally store the theme if applicable
        if (themeInputField != null && !string.IsNullOrEmpty(themeInputField.text))
        {
            dataManager.Theme = themeInputField.text;
        }
    }

    // Method to display the popup message
    private void ShowPopup(string message)
    {
        if (popupMessage != null)
        {
            popupMessage.SetActive(true);
            TMP_Text popupText = popupMessage.GetComponentInChildren<TMP_Text>();
            if (popupText != null)
            {
                popupText.text = message;
            }
            else
            {
                Debug.LogWarning("Popup message TMP_Text component is missing!");
            }
        }
        else
        {
            Debug.LogWarning("Popup message GameObject is not assigned!");
        }
    }
}
