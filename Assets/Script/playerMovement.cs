using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{
    private float speed = 0f;
    private float scaleX = 0f;
    private float lompat = 9f;
    private float jumpCount = 0f;
    private float jumpValue = 3f;

    private bool isGrounded = true;
    private Animator anim;

    void Start()
    {
        scaleX = transform.localScale.x;
        anim = GetComponent<Animator>();
    }

    public void berlari()
    {
        transform.localScale = new Vector3(scaleX, transform.localScale.y, transform.localScale.z);
        transform.Translate(Vector3.right * speed * Time.fixedDeltaTime, Space.Self);
    }

    public void melompat()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && jumpCount > 0) {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * lompat;
            isGrounded = false;
            jumpCount--;
            anim.SetBool("isJumping", true);
        }
        else
        {
            anim.SetBool("isJumping", false);
        }
    }

    public void merunduk()
    {
        if (Input.GetKey(KeyCode.DownArrow) && isGrounded) {
            GetComponent<PolygonCollider2D>().enabled = false;
            anim.SetBool("isSliding", true);
        } else {
            GetComponent<PolygonCollider2D>().enabled = true;
            anim.SetBool("isSliding", false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        berlari();
        melompat();
        merunduk();

        if (isGrounded)
        {
            jumpCount = jumpValue;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground" && !isGrounded)
        {
            isGrounded = true;

        }
    }
}
