using UnityEngine;

public class MoveBackGround : MonoBehaviour
{
    public GameObject player;
    public GameObject background2;

    public bool isBackgroundMoving = false;
    public float currentBackgroundSpeed;

    public void StartMovingBackground(float speed)
    {
        isBackgroundMoving = true;
        currentBackgroundSpeed = speed;
        Debug.Log("Background starts moving at speed: " + currentBackgroundSpeed);
    }

    private void Update()
    {
        if (isBackgroundMoving)
        {
            MoveBackground();
        }
    

        if (HasReachedLimit())
        {
            if (background2 != null && background2.transform.position.x <= -90)
            {
                background2.transform.position = new Vector3(90.1f, background2.transform.position.y, background2.transform.position.z);
                Background2Mover background2Mover = background2.GetComponent<Background2Mover>();
                if (background2Mover != null)
                {
                    background2Mover.isBackgroundMoving2 = true;
                    background2Mover.StartMovingBackground(currentBackgroundSpeed);
                }
            }
        }
    }

    public void MoveBackground()
    {
        
        if (isBackgroundMoving && transform.position.x > -95)
        {
            isBackgroundMoving = true;
            transform.position -= new Vector3(currentBackgroundSpeed * Time.deltaTime, 0f, 0f);
            Debug.Log(Time.deltaTime);
        }
        else
        {
            isBackgroundMoving = false;
            Debug.Log("Background reached limit.");
        }
    }

    public void SetBackgroundSpeed(float speed)
    {
        currentBackgroundSpeed = speed;
    }

    public void IncreaseBackgroundSpeed(float increaseAmount)
    {
        currentBackgroundSpeed += increaseAmount;
        Debug.Log("Background speed increased to: " + currentBackgroundSpeed);
    }

    public bool HasReachedLimit()
    {
        return transform.position.x <= -75;
    }

    public void StopBackground1Movement()
    {
        isBackgroundMoving = false; 
    }
}


