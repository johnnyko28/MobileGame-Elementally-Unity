﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject Pause_Menu, PauseButton, Level, InfoButton;

    public void Pause()
    {
        Level.SetActive(false);
        InfoButton.SetActive(false);
        Pause_Menu.SetActive(true);
        PauseButton.SetActive(false);

    }

    public void Resume()
    {
        Level.SetActive(true);
        InfoButton.SetActive(true);
        Pause_Menu.SetActive(false);
        PauseButton.SetActive(true);
    }

    public void Quit()
    {
        Debug.Log("Game End in Build Mode");
        var levelManager = Level.GetComponent<LevelManager>();
        if (levelManager != null) levelManager.ResetLevel();
        Application.Quit();
    }

    public void Replay()
    {
        Debug.Log("Replay");
        var levelManager = Level.GetComponent<LevelManager>();
        if (levelManager != null) levelManager.ResetLevel();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Info()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}