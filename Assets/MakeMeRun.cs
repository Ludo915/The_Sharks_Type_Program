using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Collections.Generic;


public class MakeMeRun : MonoBehaviour
{
    public Text displayText;
    public TextMeshProUGUI TargetTextText;
    public GameObject player;
    public MoveBackGround backgroundScript;
    public Background2Mover background2Script; // Reference to the Background2 script
    public TypeManager TypeManager;
    public Animator keyboardAnimator;
    public Animator wolfAnimator;
    public TextMeshProUGUI scoreText; // Reference to TextMeshPro in the ScoreBoard scene
    public Image MistakeImage;
    // Audio sources for jappements
    public AudioSource Jappement1;
    public AudioSource Jappement2;
    public AudioSource Jappement3;
    public AudioSource Jappement4;
    public AudioSource Jappement5;
    public AudioSource Buzzer;
    public AudioSource BruitTouche1;
    public AudioSource BruitTouche2;
    public AudioSource BruitTouche3;
    public AudioSource BruitTouche4;
    public AudioSource BruitToucheSpace;
    public AudioSource BruitToucheFinal;


    public float walkingSpeed = 2f;
    public float speedIncrease = 0.25f;
    public bool isRunning = false;
    private int currentIndex = 0;
    private float currentSpeed = 0f;
    public string targetText = "";
    private enum MovementState { WaitingForInput, PlayerMoving, BackgroundMoving, PlayerResumesMoving }
    private MovementState movementState = MovementState.WaitingForInput;
    private char currentchar;
    private void Start()
    {
        targetText = DataManager.Instance.TargetText;
        currentSpeed = 0f;

        // Ensure animation is in idle state at the start
        if (wolfAnimator != null)
        {
            wolfAnimator.SetBool("isRunning", false);
        }
        if (keyboardAnimator != null)
        {
            keyboardAnimator.SetTrigger("Idle");
            wolfAnimator.SetTrigger("Idle");
        }
    }

    private void Update()
    {
        if (isRunning == false && currentSpeed >= 4f)
        {
            wolfAnimator.SetTrigger("TriggerRun");
            isRunning = true;
            wolfAnimator.SetBool("isRunning", true);
        }
        // If typing is complete, load final scores
        if (currentIndex >= targetText.Length)
        {
            movementState = MovementState.PlayerResumesMoving;
            StartCoroutine(HandleFinalScoresWithDelay());
            return;
        }

        // Handle typing input only if typing has started
        if (currentIndex > 0 && Input.anyKeyDown)
        {
            HandleInput();
        }

        else if (Input.anyKeyDown == false && currentIndex ==0)
        {
            char currentchar = targetText[0];
            keyboardAnimator.SetTrigger(keyAnimationsTriggers[currentchar]);
            keyboardAnimator.SetBool("IsIdle", false);


        }
        else if (Input.anyKeyDown && currentIndex == 0)
        {
            // Initialize movement and handle first character input
            wolfAnimator.SetTrigger("TriggerWalk");
            if (Input.inputString.Substring(0, 1) != " ")
            {
                PlayRandomTouche();
            }
            else
            {
                BruitToucheSpace.Play();
            }    
            HandleFirstCharacter();
        }

        // Continue the movement logic here based on the movement state
        HandleMovementLogic();
    }

    private void HandleInput()
    {
        string input = Input.inputString;
        if (!string.IsNullOrEmpty(input))
        {
            char typedChar = input[0];
            if (currentIndex + 1 <= targetText.Length - 2)
            {
                currentchar = targetText[currentIndex + 1];
            }
            
                //PlayAndPauseAnimation("Trigger" + currentchar);
            keyboardAnimator.SetTrigger(keyAnimationsTriggers[currentchar]);
            keyboardAnimator.SetBool("IsIdle", false);

            if (typedChar == targetText[currentIndex])
            {
                keyboardAnimator.SetTrigger(keyAnimationsSuccesses[typedChar]);
                keyboardAnimator.SetBool("IsIdle", true);
   
                //PlayAndPauseAnimation("Success" + typedChar);
                
                // Move to the next character in the target text
                if (currentIndex == targetText.Length - 1)
                {
                    BruitToucheFinal.Play();
                }
                else
                {
                    PlayRandomTouche();
                }
                currentIndex++;
                HandleCorrectInput();
            }
            else
            {
                PlayRandomTouche();
                TriggerFall(); // Only calls if incorrect character is typed
            }
        }
    }

    private void HandleFirstCharacter()
    {
        string input = Input.inputString;
        
        if (!string.IsNullOrEmpty(input) && input[0] == targetText[0])
        {
            keyboardAnimator.SetTrigger(keyAnimationsSuccesses[input[0]]);
            keyboardAnimator.SetBool("IsIdle", false);

            currentIndex++;
            movementState = MovementState.PlayerMoving;
            currentSpeed = walkingSpeed;

            if (wolfAnimator != null)
            {
                wolfAnimator.SetBool("isWalking", true);
            }

            TypeManager.UpdateTypedCharacters(currentIndex);
            displayText.text = "<color=green>" + targetText.Substring(0, currentIndex) + "</color>" + targetText.Substring(currentIndex);
        }
    }

    private void HandleCorrectInput()
    {
        currentSpeed += speedIncrease;
        TypeManager.UpdateTypedCharacters(currentIndex);

        if (movementState == MovementState.BackgroundMoving)
        {
            backgroundScript.IncreaseBackgroundSpeed(speedIncrease);
            background2Script?.IncreaseBackgroundSpeed(speedIncrease);
        }

        //displayText.text = "<color=green>" + targetText.Substring(0, currentIndex) + "</color>" + targetText.Substring(currentIndex);
    }

    private void HandleMovementLogic()
    {
        switch (movementState)
        {
            case MovementState.PlayerMoving:
                if (player.transform.position.x < 0)
                {
                    MovePlayer();
                }
                else
                {
                    movementState = MovementState.BackgroundMoving;
                    backgroundScript.StartMovingBackground(currentSpeed);
                }
                break;

            case MovementState.BackgroundMoving:
                if (!backgroundScript.HasReachedLimit())
                {
                    backgroundScript.MoveBackground();
                }
                else
                {
                    if (!background2Script.HasReachedLimit())
                    {
                        background2Script.StartMovingBackground(currentSpeed);
                    }
                }
                break;

            case MovementState.PlayerResumesMoving:
                backgroundScript.StopBackground1Movement();
                background2Script?.StopBackground2Movement();

                if (currentIndex >= targetText.Length)
                {
                    MovePlayer();
                }
                break;
        }

        if (player.transform.position.x < 0 && currentIndex >= targetText.Length)
        {
            backgroundScript.StopBackground1Movement();
            background2Script?.StopBackground2Movement();
            movementState = MovementState.PlayerResumesMoving;
            MovePlayer();
        }

        if (player.transform.position.x >= 0 && currentIndex >= targetText.Length)
        {
            backgroundScript.StopBackground1Movement();
            background2Script?.StopBackground2Movement();
            movementState = MovementState.PlayerResumesMoving;
            MovePlayer();
        }
        //ResetKeyboardAnimator();
    }

    private void MovePlayer()
    {
        backgroundScript.StopBackground1Movement();
        background2Script?.StopBackground2Movement();
        if (movementState == MovementState.PlayerMoving || movementState == MovementState.PlayerResumesMoving)
        {
            player.transform.Translate(Vector3.right * currentSpeed * Time.deltaTime);
        }
    }

    private void TriggerFall()
    {
        Debug.Log("Le personnage trébuche et fait une roulade !");
        TypeManager.IncrementTriggerFalls();
        wolfAnimator.SetTrigger("TriggerWalk");
        wolfAnimator.SetBool("IsRunning", false);
        isRunning = false;
        // Play a random jappement sound
        PlayRandomJap();
        //PlayRandomJappement();
        StartCoroutine(ShowAndFadeMistakeImage());

        // Reset the speed for both Background1 and Background2 when fall occurs
        currentSpeed = walkingSpeed;

        if (backgroundScript.isBackgroundMoving == true)
        {
            backgroundScript.SetBackgroundSpeed(currentSpeed);
        }
        if (background2Script.isBackgroundMoving2 == true)
        {
            background2Script?.SetBackgroundSpeed(currentSpeed);
        }
    }

    private void PlayRandomTouche()
    {
        AudioSource[] touches = { BruitTouche1, BruitTouche2, BruitTouche3, BruitTouche4};
        int randomIndex = Random.Range(0, touches.Length);
        touches[randomIndex].Play();
    }
    private void PlayRandomJap()
    {
        AudioSource[] jap = { Jappement1, Jappement2, Jappement3};
        int randomIndex = Random.Range(0, jap.Length);
        jap[randomIndex].Play();
    }

    private IEnumerator ShowAndFadeMistakeImage()
    {
        if (MistakeImage != null)
        {
            // Set random X position between -600 and 600
            float randomX = Random.Range(-600f, 600f);
            
            // Set the MistakeImage's position
            RectTransform rectTransform = MistakeImage.GetComponent<RectTransform>();
            rectTransform.anchoredPosition = new Vector2(randomX, rectTransform.anchoredPosition.y); // Set X, keep Y the same

            // Make the image fully visible
            MistakeImage.gameObject.SetActive(true);
            Color color = MistakeImage.color;
            color.a = 1f;
            MistakeImage.color = color;

            // Wait for 0.5 seconds
            yield return new WaitForSeconds(0.5f);

            // Gradually fade out
            float fadeDuration = 0.5f;
            float elapsedTime = 0f;

            while (elapsedTime < fadeDuration)
            {
                elapsedTime += Time.deltaTime;
                color.a = Mathf.Lerp(1f, 0f, elapsedTime / fadeDuration);
                MistakeImage.color = color;
                yield return null;
            }

            // Ensure the image is fully transparent at the end
            color.a = 0f;
            MistakeImage.color = color;

            // Deactivate the MistakeImage after fading
            MistakeImage.gameObject.SetActive(false);
        }
    }
    private IEnumerator HandleFinalScoresWithDelay()
    {
        movementState = MovementState.PlayerResumesMoving;
        MovePlayer();
        
        yield return new WaitForSeconds(3f);
        
        ShowFinalScores();
    }

    private void PlayAndPauseAnimation(string animationName)
    {
        if (keyboardAnimator != null)
        {
            // Trigger the animation
            keyboardAnimator.SetTrigger(animationName);

            // Wait for the animation to complete, then pause
            //StartCoroutine(PauseAnimatorOnLastFrame(animationName));
        }
    }

    private IEnumerator PauseAnimatorOnLastFrame(string animationName)
    {
        if (keyboardAnimator == null)
            yield break;

        // Wait until the animation reaches its last frame
        while (keyboardAnimator.GetCurrentAnimatorStateInfo(0).IsName(animationName) &&
               keyboardAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
        {
            yield return null;
        }

        // Stop the animator on the last frame
        keyboardAnimator.speed = 0f;
    }

    private void ResetKeyboardAnimator()
    {
        if (keyboardAnimator != null)
        {
            keyboardAnimator.speed = 1f; // Resume speed
            keyboardAnimator.Play("Idle", 0, 0f); // Reset to Idle
        }
    }

    private void ShowFinalScores()
    {
        int wpm = TypeManager.CalculateWPM();
        float accuracy = TypeManager.CalculateAccuracy();
        float score = TypeManager.CalculateScore();
        string level = TypeManager.CalculateLevel(wpm); 
        DataManager.Instance.WPM = wpm;
        DataManager.Instance.Accuracy = accuracy;
        DataManager.Instance.Score = score;
        DataManager.Instance.Level = level;
        UnityEngine.SceneManagement.SceneManager.LoadScene("ScoreBoard");
    }

    // Triggers Dictionary
    private Dictionary<char, string> keyAnimationsTriggers = new Dictionary<char, string>()
    {   { '1', "Trigger1"},
        { '2', "Trigger2"},
        { '3', "Trigger3"},
        { '4', "Trigger4"},
        { '5', "Trigger5"},
        { '6', "Trigger6"},
        { '7', "Trigger7"},
        { '8', "Trigger8"},
        { '9', "Trigger9"},
        { '0', "Trigger0"},
        { ' ', "Triggerspacebar"},
        { '.', "Triggerpoint"},
        // Lowercase letters
        { 'a', "Triggera" },
        { 'à', "Triggerà" },
        { 'b', "Triggerb" },
        { 'c', "Triggerc" },
        { 'd', "Triggerd" },
        { 'e', "Triggere" },
        { 'é', "Triggeré"},
        { 'è', "Triggerè"},
        { 'f', "Triggerf" },
        { 'g', "Triggerg" },
        { 'h', "Triggerh" },
        { 'i', "Triggeri" },
        { 'j', "Triggerj" },
        { 'k', "Triggerk" },
        { 'l', "Triggerl" },
        { 'm', "Triggerm" },
        { 'n', "Triggern" },
        { 'o', "Triggero" },
        { 'ô', "Triggerô"} ,
        { 'p', "Triggerp" },
        { 'q', "Triggerq" },
        { 'r', "Triggerr" },
        { 's', "Triggers" },
        { 't', "Triggert" },
        { 'u', "Triggeru" },
        { 'v', "Triggerv" },
        { 'w', "Triggerw" },
        { 'x', "Triggerx" },
        { 'y', "Triggery" },
        { 'z', "Triggerz" },

        // Uppercase letters
        { 'A', "Triggercapitala" },
        { 'B', "Triggercapitalb" },
        { 'C', "Triggercapitalc" },
        { 'D', "Triggercapitald" },
        { 'E', "Triggercapitale" },
        { 'F', "Triggercapitalf" },
        { 'G', "Triggercapitalg" },
        { 'H', "Triggercapitalh" },
        { 'I', "Triggercapitali" },
        { 'J', "Triggercapitalj" },
        { 'K', "Triggercapitalk" },
        { 'L', "Triggercapitall" },
        { 'M', "Triggercapitalm" },
        { 'N', "Triggercapitaln" },
        { 'O', "Triggercapitalo" },
        { 'P', "Triggercapitalp" },
        { 'Q', "Triggercapitalq" },
        { 'R', "Triggercapitalr" },
        { 'S', "Triggercapitals" },
        { 'T', "Triggercapitalt" },
        { 'U', "Triggercapitalu" },
        { 'V', "Triggercapitalv" },
        { 'W', "Triggercapitalw" },
        { 'X', "Triggercapitalx" },
        { 'Y', "Triggercapitaly" },
        { 'Z', "Triggercapitalz" },

        //Special Characters
        { ',', "Triggervirgule"},
        { ';', "Triggerspointvirgule"},
        { '\'', "Triggerapostrophe" },
        { '-', "Triggerhyphen"}
    };

    // Successes Dictionary
    private Dictionary<char, string> keyAnimationsSuccesses = new Dictionary<char, string>()
    {
        { '1', "Success1"},
        { '2', "Success2"},
        { '3', "Success3"},
        { '4', "Success4"},
        { '5', "Success5"},
        { '6', "Success6"},
        { '7', "Success7"},
        { '8', "Success8"},
        { '9', "Success9"},
        { '0', "Success0"},
        {' ', "Successspacebar" },
        {'.', "Successpoint"},
        // Lowercase letters
        { 'a', "Successa" },
        { 'à', "Successà"},
        { 'â', "Successâ"},
        { 'b', "Successb" },
        { 'c', "Successc" },
        { 'd', "Successd" },
        { 'e', "Successe" },
        { 'é', "Successé"},
        { 'è', "Successè"},
        { 'f', "Successf" },
        { 'g', "Successg" },
        { 'h', "Successh" },
        { 'i', "Successi" },
        { 'j', "Successj" },
        { 'k', "Successk" },
        { 'l', "Successl" },
        { 'm', "Successm" },
        { 'n', "Successn" },
        { 'o', "Successo" },
        { 'ô', "Successô"},
        { 'p', "Successp" },
        { 'q', "Successq" },
        { 'r', "Successr" },
        { 's', "Successs" },
        { 't', "Successt" },
        { 'u', "Successu" },
        { 'v', "Successv" },
        { 'w', "Successw" },
        { 'x', "Successx" },
        { 'y', "Successy" },
        { 'z', "Successz" },

        // Uppercase letters
        { 'A', "Successcapitala" },
        { 'B', "Successcapitalb" },
        { 'C', "Successcapitalc" },
        { 'D', "Successcapitald" },
        { 'E', "Successcapitale" },
        { 'F', "Successcapitalf" },
        { 'G', "Successcapitalg" },
        { 'H', "Successcapitalh" },
        { 'I', "Successcapitali" },
        { 'J', "Successcapitalj" },
        { 'K', "Successcapitalk" },
        { 'L', "Successcapitall" },
        { 'M', "Successcapitalm" },
        { 'N', "Successcapitaln" },
        { 'O', "Successcapitalo" },
        { 'P', "Successcapitalp" },
        { 'Q', "Successcapitalq" },
        { 'R', "Successcapitalr" },
        { 'S', "Successcapitals" },
        { 'T', "Successcapitalt" },
        { 'U', "Successcapitalu" },
        { 'V', "Successcapitalv" },
        { 'W', "Successcapitalw" },
        { 'X', "Successcapitalx" },
        { 'Y', "Successcapitaly" },
        { 'Z', "Successcapitalz" },

        //Special characters
        { ',', "Successvirgule"},
        { ';', "Successpointvirgule"},
        { '\'', "Successapostrophe" },
        { '-', "Successhyphen"}

    };

}
