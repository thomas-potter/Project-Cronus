using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject settingsMenu;
    [SerializeField] bool inSettings = false;

    public void StartGame()
    {
        SceneManager.LoadScene(sceneName: "Level");
    }

    public void RunSettings()
    {
        settingsMenu.SetActive(true);

        inSettings = true;
    }

    public void CloseSettings()
    {
        settingsMenu.SetActive(false);
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
