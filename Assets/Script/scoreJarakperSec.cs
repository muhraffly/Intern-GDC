using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreJarakperSec : MonoBehaviour
{
    public Text scoreJarak;
    public float scoreAmount = 0f;
    private float poinMeningkatPerDetik = 100f;
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
    public void Update ()
    {
        scoreJarak.text = (int)scoreAmount + "m";
        scoreAmount += poinMeningkatPerDetik * Time.deltaTime;
        PlayerPrefs.SetFloat("jarak", scoreAmount);
    }
}
