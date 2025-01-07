using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class TypeManager : MonoBehaviour
{
    private string targetText;
    private int currentIndex = 0;
    private int totalCorrectCharacters = 0;
    private int nbTriggerFalls = 0;  // Counter for the number of TriggerFalls (mistakes)
    private float startTime;
   
    

    private void Start()
    {
        targetText = DataManager.Instance.TargetText;
        startTime = Time.time;  // Start the timer when the game begins
    }

    

    

    public void UpdateTypedCharacters(int correctCount)
    {
        currentIndex = correctCount;
        totalCorrectCharacters++;
    }

    // Increment the trigger fall counter
    public void IncrementTriggerFalls()
    {
        nbTriggerFalls++;
    }

    // Calculate Words Per Minute
    public int CalculateWPM()
    {
        int wpm2;
        float timeElapsed = Time.time - startTime;
        int wordsTyped = targetText.Substring(0, currentIndex).Split(' ').Length;
        float wpm = (wordsTyped / timeElapsed) * 60;  // Convert to words per minute
        wpm2 = Mathf.RoundToInt(wpm);
        
        return wpm2;
    }

    // Calculate Accuracy Percentage
    public float CalculateAccuracy()
    {
        float accuracy = ((totalCorrectCharacters - nbTriggerFalls) / (float)targetText.Length) * 100;
        return Mathf.Max(0, accuracy);  // Ensure accuracy is not negative
    }

    public float CalculateScore()
    {
        float Score = CalculateWPM()*100f + CalculateAccuracy()*50f;
        return Score;
    }

    public string CalculateLevel(int wpm)
    {
        string level = "";
        wpm = Mathf.RoundToInt(wpm);
        if ( wpm > 100)
        {
            level = "26 Dieu";
        }
        else if (wpm >= 0 && wpm <= 4)
        {
            level = "1 Limace";
        }
        else if (wpm <= 8)
        {
            level = "2 Escargot";
        }
        else if (wpm <= 12)
        {
            level = "3 Tortue";
        }
        else if (wpm <= 16)
        {
            level = "4 Paresseux";
        }
        else if (wpm <= 20)
        {
            level = "5 Fourmi";
        }
        else if (wpm <= 24)
        {
            level = "6 Chenille";
        }
        else if (wpm <= 28)
        {
            level = "7 Grenouille";
        }
        else if (wpm <= 32)
        {
            level = "8 Hérisson";
        }
        else if (wpm <= 36)
        {
            level = "9 Lapin";
        }
        else if (wpm <= 40)
        {
            level = "10 Renard";
        }
        else if (wpm <= 44)
        {
            level = "11 Blaireau";
        }
        else if (wpm <= 48)
        {
            level = "12 Loutre";
        }
        else if (wpm <= 52)
        {
            level = "13 Singe";
        }
        else if (wpm <= 56)
        {
            level = "14 Raton laveur";
        }
        else if (wpm <= 60)
        {
            level = "15 Castor";
        }
        else if (wpm <= 64)
        {
            level = "16 Lynx";
        }
        else if (wpm <= 68)
        {
            level = "17 Chèvre";
        }
        else if (wpm <= 72)
        {
            level = "18 Cerf";
        }
        else if (wpm <= 76)
        {
            level = "19 Loup";
        }
        else if (wpm <= 80)
        {
            level = "20 Puma";
        }
        else if (wpm <= 84)
        {
            level = "21 Guépard";
        }
        else if (wpm <= 88)
        {
            level = "22 Aigle";
        }
        else if (wpm <= 92)
        {
            level = "23 Faucon";
        }
        else if (wpm <= 96)
        {
            level = "24 Faucon pèlerin";
        }
        else if (wpm <= 100)
        {
            level = "25 Jaguar";
        }

        return level;
    }

    
    public int GetCorrectCharacterCount()
    {
        return currentIndex;
    }

    // Retrieve the number of TriggerFalls
    public int GetTriggerFallCount()
    {
        return nbTriggerFalls;
    }
}
