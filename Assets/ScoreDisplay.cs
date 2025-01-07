using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class YourScript : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text levelText;
    public TMP_Text nameText;

    private void Start()
    {
        // Check if DataManager instance exists
        if (DataManager.Instance != null)
        {
            // Retrieve data from DataManager
            int wpm = Mathf.RoundToInt(DataManager.Instance.WPM); // Rounds to the nearest integer
            int accuracy = Mathf.RoundToInt(DataManager.Instance.Accuracy); // Rounds to the nearest integer
            int score = Mathf.RoundToInt(DataManager.Instance.Score);
            string level = DataManager.Instance.Level;
            string name = DataManager.Instance.Name;
            Debug.Log($"Name:{name}");

            // Display the scores in the UI
            scoreText.text = $"{wpm}\n\n\n\n{accuracy}%\n\n\n\n{score}";
            levelText.text = $"{level}";
            nameText.text = $"{name} prends conscience de";

            // Define path to Rankings.csv in the persistent data path
            string path = Path.Combine(Application.persistentDataPath, "Rankings.csv");

            // Check if Rankings.csv exists, and create an empty file with a header if it doesn't
            if (!File.Exists(path))
            {
                using (var writer = new StreamWriter(path, false))
                {
                    writer.WriteLine("Rank,Name,Score,WPM,Accuracy,Level"); // Header with Rank column
                }
                Debug.Log($"Created Rankings.csv at {path}");
            }

            // Load and parse the rankings data
            List<string[]> rankings = new List<string[]>();
            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);
                foreach (var line in lines.Skip(1)) // Skip header
                {
                    var values = line.Split(',');
                    if (values.Length == 6) rankings.Add(values);
                }
            }

            // Check if the player's name already exists in the file
            var existingEntry = rankings.FirstOrDefault(r => r[1] == name);
            if (existingEntry != null)
            {
                // Update the entry if the new score is higher
                int existingScore = int.Parse(existingEntry[2]);
                if (score > existingScore)
                {
                    existingEntry[2] = score.ToString();
                    existingEntry[3] = wpm.ToString();
                    existingEntry[4] = accuracy.ToString();
                    existingEntry[5] = level;
                }
            }
            else
            {
                // Add new entry if the player's name was not found
                rankings.Add(new string[] { "", name, score.ToString(), wpm.ToString(), accuracy.ToString(), level });
            }

            // Sort rankings by score in descending order
            rankings = rankings.OrderByDescending(r => int.Parse(r[2])).ToList();

            // Assign rank based on sorted order
            for (int i = 0; i < rankings.Count; i++)
            {
                rankings[i][0] = (i + 1).ToString(); // Rank is assigned based on position in sorted list
            }

            // Write the sorted data back to the CSV file
            using (var writer = new StreamWriter(path, false))
            {
                writer.WriteLine("Rank,Name,Score,WPM,Accuracy,Level"); // Header with Rank column
                foreach (var entry in rankings)
                {
                    writer.WriteLine($"{entry[0]},{entry[1]},{entry[2]},{entry[3]},{entry[4]},{entry[5]}");
                }
            }

            Debug.Log($"Rankings saved to {path}");
        }
        else
        {
            // If DataManager is missing, display an error message
            scoreText.text = "Data unavailable.";
            Debug.LogWarning("DataManager instance not found. Ensure the Jungle scene was loaded before this scene.");
        }
    }
}
