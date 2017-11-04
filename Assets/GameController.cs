using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public GameObject gameOverCanvas;
    public int level;
    public GameObject gameMenu;

    public void EndGame()
    {
        gameOverCanvas.SetActive(true);
    }

    public void NextMap()
    {
        if (level + 1 < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(level + 1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(gameMenu.activeInHierarchy)
            {
                gameMenu.SetActive(false);
                Time.timeScale = 1f;
            }
            else
            {
                gameMenu.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }

    public void ResumeGame()
    {
        gameMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
