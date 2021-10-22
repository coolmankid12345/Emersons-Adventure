﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    
    /*
    void Start()
    {
        PausePanel.SetActive(false);
    }
    */

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    //public void LoadMenu()
    //{
    //    Debug.Log("Loading menu...");
    //}
    public void QuitGame()
    {
        Debug.Log("Quiting game...");
        Application.Quit();
    }

    void VolumeUp()
    {
        
    }

    void VolumeDown()
    {

    }
}