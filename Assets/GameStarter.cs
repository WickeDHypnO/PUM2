using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStarter : MonoBehaviour {

    public GameObject levelSelect;

	public void StartGame(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void ShowLevels()
    {
        levelSelect.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
