using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class TextInitializerKDEI: MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static void Startkdei()
    {
        DataManager.Instance.TargetText = GetTutorialText();
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public static string GetTutorialText()
    {
        List<string> myStringList = new List<string>();
        List<string> words = new List<string>();
        for (int j = 0; j < 20; j++)
            {
                int wordLength = UnityEngine.Random.Range(1, 7); // Génère la longueur du mot entre 1 et 6
                char[] word = new char[wordLength];

                for (int k = 0; k < wordLength; k++)
                {
                    // Choisir aléatoirement entre 'j' et 'f' pour chaque lettre
                    int choice = UnityEngine.Random.Range(0, 4);
                    word[k] = choice switch
                    {
                        0 => 'k',
                        1 => 'd',
                        2 => 'e',
                        3 => 'i'
                    };
                }

                words.Add(new string(word));
            }

            myStringList.Add(string.Join(" ", words));

     // Retourner la chaîne au hasard
        return myStringList[0];
    }
}
