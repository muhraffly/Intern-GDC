using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    float Ycoin;
    public float kecepatan;
    // Start is called before the first frame update
    void Start()
    {
        kecepatan = 0.020f;
        Ycoin = Random.Range(-2, 1);

    }
    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1)
        {
            transform.localPosition = new Vector3(transform.localPosition.x - kecepatan, Ycoin, 1f);
        }
    }
}
