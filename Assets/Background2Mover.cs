using UnityEngine;

public class Background2Mover : MonoBehaviour
{
    public GameObject background1;  // Reference to the Background1 image object
    public bool isBackgroundMoving2 = false;
    private float currentBackgroundSpeed;
    

    public void StartMovingBackground(float speed)
    {
        isBackgroundMoving2 = true;
        currentBackgroundSpeed = speed;
        Debug.Log("Background2 starts moving at speed: " + currentBackgroundSpeed);
    }

    private void Update()
    {
        MoveBackground();

        // Check if Background2 has moved past the x=-65 limit
        if (HasReachedLimit())
        {

            // Trigger Background1 to spawn at x=80 and start moving
            if (background1 != null)
            {  
                MoveBackGround background1Script = background1.GetComponent<MoveBackGround>();
                if (background1Script.isBackgroundMoving == false)
                {   
                    background1.transform.position = new Vector3(99.1f, background1.transform.position.y, background1.transform.position.z);
                    
                    background1Script.StartMovingBackground(currentBackgroundSpeed);
                    background1Script.isBackgroundMoving = true;
                    Debug.Log("Background1 started moving at speed: " + currentBackgroundSpeed);
                }
                else
                {
                    background1Script.MoveBackground();
                }
            }
        }
    }

    public void MoveBackground()
    {
        if (isBackgroundMoving2 && transform.position.x > -100)
        {
            // Move the background based on currentBackgroundSpeed
            transform.position -= new Vector3(currentBackgroundSpeed * Time.deltaTime, 0f, 0f);
        }
        else if (transform.position.x <= -100)
        {
            isBackgroundMoving2 = false;
            Debug.Log("Background2 stopped moving.");
        }
    }

    public void SetBackgroundSpeed(float speed)
    {
        // Update the background speed directly
        currentBackgroundSpeed = speed;
    }

    public void IncreaseBackgroundSpeed(float increaseAmount)
    {
        // Increase the background speed
        currentBackgroundSpeed += increaseAmount;
        Debug.Log("Background2 speed increased to: " + currentBackgroundSpeed);
    }

    public bool HasReachedLimit()
    {
        // Limit adjusted to -65 as specified
        return transform.position.x <= -75;
    }

    public void StopBackground2Movement()
    {
        isBackgroundMoving2 = false;
    }
}

