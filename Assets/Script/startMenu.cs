using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startMenu : MonoBehaviour
{
    public GameObject control;
    public GameObject tutorial;

    public void play(string Gameplay)
    {
        Application.LoadLevel(Gameplay);
        Time.timeScale = 1;
        FindObjectOfType<AudioManager>().Play("backsoundGame");
        FindObjectOfType<AudioManager>().Play("sirine");


    }
    public void exit()
    {
        Application.Quit();
        //Debug.Log("Bisa Exit Game");
    }

    public void backMenu(string startMenu)
    {
        Application.LoadLevel(startMenu);
        FindObjectOfType<AudioManager>().Stop("sirine");
        FindObjectOfType<AudioManager>().Play("backsoundGame");
        FindObjectOfType<AudioManager>().Stop("deathSound");

    }

    public void controlSlide()
    {
        control.SetActive(true);
        tutorial.SetActive(false);

    }

    public void tutorSlide()
    {
        control.SetActive(false);
        tutorial.SetActive(true);
    }

}