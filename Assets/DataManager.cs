using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance { get; private set; }
    public string Level { get; set; }
    public float Score { get; set; }
    public int WPM { get; set; }
    public float Accuracy { get; set; }
    public string Name { get; set; }
    public string Theme { get; set; }
    public string TargetText {get; set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Make this persistent across scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
