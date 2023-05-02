using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEditor;
using UnityEngine.SceneManagement;


public class PointsLives : MonoBehaviour
{


    public static int points = 0;
    public Text pointsText;

    public static int highScorePref = 0;
    public static int resetScore;

    public static int lives;
    public Text livesText;
    public Text NameText;

    public Text CountDown;
    public static float TimeRemaining;
    public bool timeleft = false;


    public void Start() {

        lives = settings.loadedLives;
        NameText.text = "Currently Playing: " + Name.PlayerName;
        TimeRemaining = settings.countdownValue;
        timeleft = true;

    }

    void Update() {

        livesText.text = lives.ToString();
        pointsText.text = points.ToString();
        CountDown.text = TimeRemaining.ToString("F2") + " seconds left";
        NameText.text = Name.PlayerName.ToString();

        if (timeleft) 
        {
            if (TimeRemaining > 0)
            {
                TimeRemaining -= Time.deltaTime;
            } else {
                CountDown.text = "0 - Time has run out!";
                timeleft = false;
            }
        }


        if (points > highScorePref)
        {
			
            PlayerPrefs.SetInt("HighScorePref", points);
            highScorePref = PlayerPrefs.GetInt("HighScorePref");
            PlayerPrefs.Save();
			
        }
        Debug.Log("HighScore = " + highScorePref);


        if (lives <= 0)
        {
            SceneManager.LoadScene("3Exit");
            Debug.Log("Game Over");
        }
	}
        
    

    public void ResetScore()
    {
        PlayerPrefs.SetInt("HighScorePref", 0);
        PlayerPrefs.Save();
        points = 0;
        resetScore = 0;
        highScorePref = 0;
        
    }


    public void IncreasePoints() {
        points = points + 1;
        pointsText.text = points.ToString();
    }
    public void DecreasePoints() {
        points = points - 1;
        pointsText.text = points.ToString();
    }
    public void IncreaseLives() {
        lives = lives + 1;
        pointsText.text = points.ToString();
    }
    public void DecreaseLives() {
        lives = lives - 1;
        livesText.text = lives.ToString();
    }


    // public void SaveToJson()
    // {

    //     JSONObject jsonObj = new JSONObject(JSONObject.Type.OBJECT);
    //     jsonObj.AddField("playerName", Name.PlayerName);
    //     jsonObj.AddField("points", points);

    //     File.WriteAllText(Application.dataPath + "/variables.json", jsonObj.ToString());
    //     Debug.Log(jsonObj.ToString());

    // }




}
