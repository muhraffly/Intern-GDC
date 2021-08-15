using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startMenu : MonoBehaviour
{

    public void play(string Gameplay)
    {
        Application.LoadLevel(Gameplay);
        Time.timeScale = 1;
    }
    public void exit()
    {
        Application.Quit();
        Debug.Log("Bisa Exit Game");
    }

    public void backMenu(string startMenu)
    {
        Application.LoadLevel(startMenu);
    }
}
