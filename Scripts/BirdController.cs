using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{

    public float jumpPower;
    Rigidbody2D rb;
    public static bool isDead;
    public static int score = 0;
    public AudioClip death;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        transform.position = Vector2.zero;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = Vector2.up * jumpPower;
            print("Jump!!");
            //transform.eulerAngles += new Vector3(0f, 0f, 25); // Açýyý 25 derece arttýrýr.
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Pipe") || collision.CompareTag("Ground"))
        {
            Destroy(gameObject);
            isDead = true;
            AudioSource.PlayClipAtPoint(death, transform.position);
            //rb.constraints = RigidbodyConstraints2D.FreezeAll; // Karakter ölünce her yöne hareketini dondurur.
        }

        if (collision.CompareTag("Score"))
        {
            score++;
        }

    }

}
