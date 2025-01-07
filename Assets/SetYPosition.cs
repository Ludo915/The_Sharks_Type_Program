using UnityEngine;

public class AdjustYByAnimation : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0); // Layer 0
        
        Vector3 position = transform.position;

        if (stateInfo.IsName("WolfAnimationWalking"))
        {
            position.y = -3.8f; // Default Y position
        }
        else if (stateInfo.IsName("WolfAnimationRunning"))
        {
            position.y = -3.8f; // Adjust for Animation2
        }
        else if (stateInfo.IsName("Idle"))
        {
        }

        transform.position = position;
    }
}
