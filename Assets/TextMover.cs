using UnityEngine;

public class TextMover : MonoBehaviour
{
    public TypeManager TypeManager;  // Reference to the TypeManager

    private bool isMoving = false;   // Whether the text is moving or not
    private int correctCharactersTyped = 0;  // Track how many correct characters have been typed

    void Start()
    {
        if (TypeManager == null)
        {
            Debug.LogError("TypeManager is not assigned!");
        }
    }

    void Update()
    {
        if (TypeManager != null)
        {
            // Get the number of correct characters typed
            int newCorrectCharactersTyped = TypeManager.GetCorrectCharacterCount();

            // If a new correct character has been typed, start moving the text
            if (newCorrectCharactersTyped > correctCharactersTyped)
            {
                correctCharactersTyped = newCorrectCharactersTyped;
                isMoving = true;  // Start moving text when a correct character is typed
            }

            // If the correct character count has decreased (indicating the user deleted a character)
            // stop moving
            else if (newCorrectCharactersTyped <= correctCharactersTyped)
            {
                correctCharactersTyped = newCorrectCharactersTyped;
                isMoving = false;  // Stop moving text if the correct character count goes down
            }

            // Move the text only if a correct character has been typed and is still being typed
            if (isMoving)
            {
                float moveSpeed = 17f;  // Adjust the factor as needed
                transform.position -= new Vector3(moveSpeed, 0f, 0f);
            }
        }
    }
}
