using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacles : MonoBehaviour
{
    float Yobstacles;
    private float kecepatan;
    // Start is called before the first frame update
    void Start()
    {
        kecepatan = .02f;
        Yobstacles = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1)
        {
            transform.localPosition = new Vector3(transform.localPosition.x - kecepatan, Yobstacles, 1f);
        }
        if (transform.position.x < -10){
            Destroy(transform.gameObject);
        } 
    }
}
