using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
   public void restartgame()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            FindObjectOfType<AudioManager>().Play("backsoundGame");
            FindObjectOfType<AudioManager>().Play("sirine");
            FindObjectOfType<AudioManager>().Stop("deathSound");

    }

}