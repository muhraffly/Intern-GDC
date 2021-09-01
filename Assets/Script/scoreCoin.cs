using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCoin : MonoBehaviour
{
    public float scorecoin;
    public Text scoreUI;
    public Text displayCoin;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
 
    }

    // Ketika collision dengan coin
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            scorecoin += 1;
            scoreUI.text = scorecoin.ToString();
            displayCoin.text = scorecoin.ToString();
            Destroy(other.gameObject);
        }
    }
}
