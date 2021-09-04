using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public float scoreAmount = 0f;
    public float poinMeningkatPerDetik = 100f;
    public int totalScore;
    public float scorecoin;
    public Text scoreUI;
    public Text displayCoin;
    public Text totalUI;
    public Text scoreJarak;
    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0f;
        //poinMeningkatPerDetik = 1.7f;
        if (Time.timeScale == 0)
        {
            scoreAmount = PlayerPrefs.GetFloat("jarak");
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreJarak.text = (int)scoreAmount + "m";
        scoreAmount += poinMeningkatPerDetik * Time.deltaTime;
        PlayerPrefs.SetFloat("jarak", scoreAmount);
    }

    // Ketika collision dengan coin
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("coins"))
        {
            FindObjectOfType<AudioManager>().Play("coinEffect");
            scorecoin += 1;
            scoreUI.text = scorecoin.ToString();
            displayCoin.text = scorecoin.ToString();
            Destroy(other.gameObject);

            totalScore = (int)scorecoin * 50;
            totalUI.text = ((int)totalScore + (int)scoreAmount).ToString() + " pts";
            
        }
    }

}
