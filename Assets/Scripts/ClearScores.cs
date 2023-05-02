using UnityEngine;
using System.IO;

public class ClearScores : MonoBehaviour
{
    private string filePath;

    private void Start()
    {
        filePath = "Assets/scoreboard.txt";
    }

    public void ClearFile()
    {
        string content = "";

        for (int i = 0; i < 10; i++)
        {
            content += "?,0\n";
        }

        File.WriteAllText(filePath, content);
    }
}