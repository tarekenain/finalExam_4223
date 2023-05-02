using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class readPoints : MonoBehaviour
{
    public Text Scoreboard;
    public int num_scores = 10;

    public void ShowTopScores()
        {
            string path = "Assets/scoreboard.txt";
            string line;
            string[] fields;
            string[] playerNames = new string[num_scores];
            int[] playerScores = new int[num_scores];
            int scores_read = 0;

            Scoreboard.text = ""; // clear the scores box

            StreamReader reader = new StreamReader(path);
            while(!reader.EndOfStream && scores_read < num_scores)
            {
                line = reader.ReadLine();
                fields = line.Split(',');
                Scoreboard.text += fields[0] + " - " + fields[1] + "\n";
                scores_read += 1;
            }

        }
}
