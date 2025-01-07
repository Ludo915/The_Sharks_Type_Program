using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class DisplayRankings : MonoBehaviour
{
    public GameObject rowPrefab;               // Prefab for each row
    public Transform boardTransform;           // Transform of the Board containing the ScrollRect
    public Scrollbar scrollbar;                // Scrollbar linked to ScrollRect
    public Color highlightColor;               // Color to highlight player's row
    public Color defaultColor;                 // Default color for other rows
    public int visibleRowCount = 16;           // Number of rows visible at once in the ScrollRect

    private Transform contentTransform;        // Content panel inside the Board
    private List<GameObject> rowInstances = new List<GameObject>(); // Store row instances
    private float rowHeight;                   // Height of each row
    private int totalRowCount;                 // Total number of rows

    private void Start()
    {
        // Locate Content inside Board
        contentTransform = boardTransform.Find("Content");

        if (contentTransform == null)
        {
            Debug.LogError("Content object not found under Board. Ensure a Content GameObject exists under Board.");
            return;
        }

        // Locate the ScrollRect component on Board
        ScrollRect scrollRect = boardTransform.GetComponent<ScrollRect>();
        if (scrollRect == null)
        {
            Debug.LogError("ScrollRect component not found on Board.");
            return;
        }

        // Assign the Content's RectTransform to the ScrollRect's content
        scrollRect.content = contentTransform.GetComponent<RectTransform>();

        // Link the scrollbar to the ScrollRect
        scrollRect.verticalScrollbar = scrollbar;
        scrollRect.horizontal = false;  // Disable horizontal scrolling

        string path = Path.Combine(Application.persistentDataPath, "Rankings.csv");

        if (File.Exists(path))
        {
            var lines = File.ReadAllLines(path);

            // Parse CSV data
            List<string[]> rows = lines.Skip(1)
                                       .Select(line => line.Split(','))
                                       .Where(values => values.Length == 6)
                                       .ToList();

            totalRowCount = rows.Count;
            rowHeight = rowPrefab.GetComponent<RectTransform>().rect.height;

            // Calculate Content height based on total row count, but limit to visibleRowCount if fewer rows
            //float contentHeight = Mathf.Min(totalRowCount, visibleRowCount) * rowHeight;
            //RectTransform contentRect = contentTransform.GetComponent<RectTransform>();
            //contentRect.sizeDelta = new Vector2(620, contentHeight);  // Set width to 620 and calculated height

            // Get the player's name (replace with DataManager.Instance.Name if using a singleton pattern)
            string playerName = DataManager.Instance.Name;
            int playerIndex = rows.FindIndex(values => values[1].Trim().Equals(playerName, System.StringComparison.OrdinalIgnoreCase));

            // Determine the range of rows to display, centered around the player’s row
            int startRow = Mathf.Clamp(playerIndex - visibleRowCount / 2, 0, Mathf.Max(0, totalRowCount - visibleRowCount));
            int endRow = Mathf.Min(startRow + visibleRowCount, totalRowCount);

            // Display rows within the determined range
            for (int i = startRow; i < endRow; i++)
            {
                // Instantiate a new row
                GameObject newRow = Instantiate(rowPrefab, contentTransform);
                rowInstances.Add(newRow);

                // Position each row vertically within the Content area
                RectTransform rowRect = newRow.GetComponent<RectTransform>();
                rowRect.anchoredPosition = new Vector2(0, -(i - startRow) * rowHeight);

                // Set row background color to highlight player's row or use default for others
                RawImage rowBackgroundImage = newRow.GetComponentInChildren<RawImage>();

                if (rowBackgroundImage != null)
                {
                    rowBackgroundImage.color = (i == playerIndex) ? highlightColor : defaultColor;
                    Debug.Log("Row " + i + " color set to: " + rowBackgroundImage.color + " for player index: " + playerIndex);
                }

                // Assign text to each row's columns
                TextMeshProUGUI[] columns = newRow.GetComponentsInChildren<TextMeshProUGUI>();
                if (columns.Length >= 6)
                {
                    columns[0].text = rows[i][0];  // Rank
                    columns[1].text = rows[i][1];  // Player Name
                    columns[2].text = rows[i][2];  // Score
                    columns[3].text = rows[i][3];  // WPM
                    columns[4].text = rows[i][4];  // Accuracy
                    columns[5].text = rows[i][5];  // Level
                }
            }

            LayoutRebuilder.ForceRebuildLayoutImmediate(contentTransform.GetComponent<RectTransform>());

            // Adjust the initial scroll position to start near the player’s row
            // float scrollPosition = Mathf.Clamp01((float)(totalRowCount - endRow) / (totalRowCount - visibleRowCount));
            // scrollbar.value = scrollPosition;

            // Add listener for scrollbar to update Content position as it's dragged
            //scrollbar.onValueChanged.AddListener(UpdateContentPosition);
        }
        else
        {
            Debug.LogWarning("Rankings.csv file not found at path: " + path);
        }
    }

    // private void UpdateContentPosition(float scrollValue)
    // {
    //     if (contentTransform != null)
    //     {
    //         float maxScroll = Mathf.Max(0, (totalRowCount - visibleRowCount) * rowHeight);
    //         float yOffset = scrollValue * maxScroll;
    //         contentTransform.localPosition = new Vector3(contentTransform.localPosition.x, Mathf.Clamp(yOffset, 0, maxScroll), contentTransform.localPosition.z);
    //     }
    // }
}
