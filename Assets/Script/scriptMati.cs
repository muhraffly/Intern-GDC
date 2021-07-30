using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptMati : MonoBehaviour
{
    public Text matiUI;
    public Text restartUI;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("stone"))
        {
            Time.timeScale = 0;
            matiUI.text = "Kamu terlindas batu";
            restartUI.text = "Tekan R buat restart";
        }
        if (collision.collider.CompareTag("Obstacle"))
        {
            Time.timeScale = 0;
            matiUI.text = "Kamu tertabrak batu";
            restartUI.text = "Tekan R buat restart";
        }
    }
}
