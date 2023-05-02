using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
using System.IO;

public class Pause : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject SettingsPanel;

    public string SavedNamePref;
    public int SavedLivesPref;
    public int SavedPointsPref;
    public float SavedTimePref;

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) 
        {
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
        SettingsPanel.gameObject.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;
        SettingsPanel.gameObject.SetActive(false);
    }


    public void NewGame()
    {
        PlayerPrefs.SetInt("HighScorePref", 0);
        PlayerPrefs.Save();
        Name.PlayerName = "New Player";
        PointsLives.points = 0;
        PointsLives.lives = 9;
        PointsLives.TimeRemaining = 45;
    }


    public void SaveGame()
    {
        PlayerPrefs.SetString("SavedName", Name.PlayerName);
        SavedNamePref = PlayerPrefs.GetString("SavedName");
        PlayerPrefs.Save();

        PlayerPrefs.SetInt("SavedLives", PointsLives.lives);
        SavedLivesPref = PlayerPrefs.GetInt("SavedLives");
        PlayerPrefs.Save();

        PlayerPrefs.SetInt("SavedPoints", PointsLives.points);
        SavedPointsPref = PlayerPrefs.GetInt("SavedPoints");
        PlayerPrefs.Save();

        PlayerPrefs.SetFloat("SavedTime", PointsLives.TimeRemaining);
        SavedTimePref = PlayerPrefs.GetFloat("SavedTime");
        PlayerPrefs.Save();

        Debug.Log("Saved");
        Debug.Log(SavedNamePref + " " + SavedLivesPref + " " + SavedPointsPref + " " + SavedTimePref);
    }

    public void LoadGame()
    {
        Name.PlayerName = SavedNamePref;
        PointsLives.points = SavedPointsPref;
        PointsLives.lives = SavedLivesPref;
        PointsLives.TimeRemaining = SavedTimePref;
        Debug.Log("Loaded");
        Debug.Log(Name.PlayerName + " " + PointsLives.points + " " + PointsLives.lives + " " + PointsLives.TimeRemaining);
    }



    private AudioSource sound;

    public Toggle toggleButton;

    void Start() {
        sound = GetComponent<AudioSource>();
        toggleButton = GetComponent<Toggle>();
        // toggleButton.onValueChanged.AddListener(Music);

    }


    public void Music(bool isOn) {
        if (isOn) {
            sound.Play();
        } else {
            sound.Stop();
        }
    }


}