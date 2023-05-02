using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    public void ToIntro()
    {
        PlayerPrefs.SetInt("HighScorePref", 0);
        PlayerPrefs.Save();
        PointsLives.resetScore = 0;
        SceneManager.LoadScene("1Intro");
    }

    PointsLives pointsLives = new PointsLives();

    public void ToMain()
    {
        PlayerPrefs.SetInt("HighScorePref", 0);
        PlayerPrefs.Save();
        PointsLives.resetScore = 0;
        PointsLives pointsLives = new PointsLives();
        pointsLives.ResetScore();
        SceneManager.LoadScene("2Game");
    }

    public void ToExit()
    {
        SceneManager.LoadScene("3Exit");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }


}

