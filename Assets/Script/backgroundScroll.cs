using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScroll : MonoBehaviour
{
    public float scrollSpeed = 4f;
    private Vector3 StartPos;
    void Start()
    {
        StartPos = transform.position;
    }

    void Update()
    {
        transform.Translate(translation: Vector3.left * scrollSpeed * Time.deltaTime);
        if (transform.position.x < -17.78f)
        {
            transform.position = StartPos;
        }
    }
}
