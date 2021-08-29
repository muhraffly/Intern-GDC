using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scriptMati : MonoBehaviour
{
    public GameObject mati;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            Time.timeScale = 0;
            mati.SetActive(true);
        }
    }
}
