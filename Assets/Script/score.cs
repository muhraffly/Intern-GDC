using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public float scoreCoin;

    public Text scoreUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("coin"))
        {
            scoreCoin += 1;
            scoreUI.text = scoreCoin.ToString();
            Destroy(collision.collider.gameObject);
        }
    }
}
