using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public static bool activePauseMenuUI = true;

    void Start()
    {
        DisplayPauseMenuUI();
    }

    public void PauseButtonPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
            DisplayPauseMenuUI();
    }

    public void DisplayPauseMenuUI()
    {
        if (activePauseMenuUI)
        {
            pauseMenuUI.SetActive(false);
            activePauseMenuUI = false;
            //Time.timeScale = 1;
        }
        else if (!activePauseMenuUI)
        {
            pauseMenuUI.SetActive(true);
            activePauseMenuUI = true;
            //Time.timeScale = 0;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


    public void Exit()
    {
        Application.Quit();
    }
}