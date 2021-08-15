using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCoin : MonoBehaviour
{
    public float scorecoin;
    public Text scoreUI;
    // Start is called before the first frame update
    void Start()
    {
        if (Time.timeScale == 0)
        {
            scorecoin = PlayerPrefs.GetFloat("coins");
        }
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    // Ketika collision dengan coin
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("coin"))
        {
            scorecoin += 1;
            scoreUI.text = scorecoin.ToString();
            Destroy(collision.collider.gameObject);
            PlayerPrefs.SetFloat("coins", scorecoin);
        }
    }
}
