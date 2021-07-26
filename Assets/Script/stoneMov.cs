using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoneMov : MonoBehaviour
{
    public float speed, scaleX;
    // Start is called before the first frame update
    
    void Start()
    {
        scaleX = transform.localScale.x;
    }

    public void rounding()
    {
        transform.localScale = new Vector3(scaleX, transform.localScale.y, transform.localScale.z);
        transform.Translate(Vector3.right * speed * Time.fixedDeltaTime, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        rounding();
    }
}
