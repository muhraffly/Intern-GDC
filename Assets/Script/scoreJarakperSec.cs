using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreJarakperSec : MonoBehaviour
{
    public Text scoreJarak;
    public float scoreAmount;
    public float poinMeningkatPerDetik;
    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0f;
        //poinMeningkatPerDetik = 1.7f;
    }

    // Update is called once per frame
    void Update()
    {
        scoreJarak.text = (int)scoreAmount + "m";
        scoreAmount += poinMeningkatPerDetik * Time.deltaTime;
    }
}
