using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scriptMati : MonoBehaviour
{
    public int health ;
    public Text healthUI;
    public GameObject mati;


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            health -= 1;
            healthUI.text = health.ToString();
            GetComponent<Animator>().SetBool("isHit", true);
            if (health == 0)
            {
                Time.timeScale = 0;
                mati.SetActive(true);
            }
        }
        else
        {
            GetComponent<Animator>().SetBool("isHit", false);
        }
    }
}
