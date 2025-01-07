using UnityEngine;

public class WolfAnimationSpeed : MonoBehaviour
{
    public Animator wolfAnimator;  // Reference to the WolfAnimation Animator component
    public TypeManager typeManager;  // Reference to the TypeManager component

    private void Start()
    {
        // Freeze the animation at the start
        if (wolfAnimator != null)
        {
            wolfAnimator.speed = 0;
        }
    }

    private void Update()
    {
        // Check if the TypeManager has registered at least one correct character
        if (typeManager != null && typeManager.GetCorrectCharacterCount() > 0)
        {
            // Unfreeze the animation when at least one correct character is typed
            if (wolfAnimator != null)
            {
                wolfAnimator.speed = 1;
            }
        }
    }
}
