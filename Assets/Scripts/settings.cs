using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settings : MonoBehaviour
{
    public Slider countdownSlider;
    public Text countdownText;
    public static float countdownValue;


    public void SetCountdown()
    {
        countdownValue = countdownSlider.value;
        countdownText.text = countdownValue.ToString();
    }





    public Dropdown SetLives;
    public static int loadedLives;



    public void ChangeLives()
    {
        
        switch(SetLives.value)
        {
            case 0:
                PlayerPrefs.SetInt("playerLives", 0);
                loadedLives = PlayerPrefs.GetInt("playerLives");
                PlayerPrefs.Save();
                break;
            case 1:
                PlayerPrefs.SetInt("playerLives", 1);
                loadedLives = PlayerPrefs.GetInt("playerLives");
                PlayerPrefs.Save();
                break;
            case 2:
                PlayerPrefs.SetInt("playerLives", 2);
                loadedLives = PlayerPrefs.GetInt("playerLives");
                PlayerPrefs.Save();
                break;
            case 3:
                PlayerPrefs.SetInt("playerLives", 3);
                loadedLives = PlayerPrefs.GetInt("playerLives");
                PlayerPrefs.Save();
                break;
            case 4:
                PlayerPrefs.SetInt("playerLives", 4);
                loadedLives = PlayerPrefs.GetInt("playerLives");
                PlayerPrefs.Save();
                break;
            case 5:
                PlayerPrefs.SetInt("playerLives", 5);
                loadedLives = PlayerPrefs.GetInt("playerLives");
                PlayerPrefs.Save();
                break;
            case 6:
                PlayerPrefs.SetInt("playerLives", 6);
                loadedLives = PlayerPrefs.GetInt("playerLives");
                PlayerPrefs.Save();
                break;
            case 7:
                PlayerPrefs.SetInt("playerLives", 7);
                loadedLives = PlayerPrefs.GetInt("playerLives");
                PlayerPrefs.Save();
                break;
            case 8:
                PlayerPrefs.SetInt("playerLives", 8);
                loadedLives = PlayerPrefs.GetInt("playerLives");
                PlayerPrefs.Save();
                break;
            case 9:
                PlayerPrefs.SetInt("playerLives", 9);
                loadedLives = PlayerPrefs.GetInt("playerLives");
                PlayerPrefs.Save();
                break;
            default:
                PlayerPrefs.SetInt("ColorCode", 0);
                loadedLives = PlayerPrefs.GetInt("ColorCode");
                PlayerPrefs.Save();
                break;
        }
    } 
}