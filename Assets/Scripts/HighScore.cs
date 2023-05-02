using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEditor;

public class HighScore : MonoBehaviour
{
	public static int CurrentScore = 0;

	public Text scoreText;

	public static int highScorePref = 0;

    public static int resetScore;


	void Start()
	{
		scoreText.text = CurrentScore.ToString();
	}
	
	void Update() 
	{
        
		if (CurrentScore > highScorePref)
        {
			
            PlayerPrefs.SetInt("HighScorePref", CurrentScore);
            highScorePref = PlayerPrefs.GetInt("HighScorePref");
            PlayerPrefs.Save();
			
        }
        Debug.Log("HS = " + highScorePref);
	}


    public void ResetScore()
    {
        PlayerPrefs.SetInt("HighScorePref", 0);
        PlayerPrefs.Save();
        CurrentScore = 0;
        resetScore = 0;
        highScorePref = 0;
        
    }
}
