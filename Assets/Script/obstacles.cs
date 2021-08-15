using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacles : MonoBehaviour
{
    float Yobstacles;
    public float kecepatan = 0.020f;
    

    void increaseSpeed() {
        kecepatan = kecepatan + 0.005f;
    }
    // Start is called before the first frame update
    void Start()
    {
        kecepatan = 0.020f;
        Yobstacles = Random.Range(-3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1)
        {
            transform.localPosition = new Vector3(transform.localPosition.x - kecepatan, Yobstacles, 1f);
        }
        if (transform.position.x < -20.05){
            Destroy(transform.gameObject);
        } 
    }
}
