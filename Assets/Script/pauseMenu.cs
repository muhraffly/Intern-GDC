using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public Button pausebtn;
    [SerializeField] GameObject PauseMenu;

    public void pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void home(int startMenu)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(startMenu);
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            pause();
        }
    }
}
