using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{
    public float speed, scaleX, lompat;
    public int jumpCount, jumpValue;

    public bool isGrounded = true;

    void Start()
    {
        scaleX = transform.localScale.x;
    }

    public void berlari()
    {
        transform.localScale = new Vector3(scaleX, transform.localScale.y, transform.localScale.z);
        transform.Translate(Vector3.right * speed * Time.fixedDeltaTime, Space.Self);
    }

    public void melompat()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * lompat;
        isGrounded = false;
        jumpCount--;
    }

    // Update is called once per frame
    void Update()
    {
        berlari();
        if (Input.GetKeyDown(KeyCode.UpArrow) && jumpCount > 0)
        {
            melompat();
        }
        if (isGrounded)
        {
            jumpCount = jumpValue;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isGrounded)
        {
            isGrounded = true;

        }
    }
}
