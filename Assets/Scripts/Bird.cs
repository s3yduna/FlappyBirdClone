using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    public bool isDead;

    public float velocity = 1f;
    public Rigidbody2D rgb;

    public GameManager gameManager;
    public GameObject deathScreen;


    private void Start()
    {
        Time.timeScale = 1;
    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            rgb.velocity = Vector2.up * velocity;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ScoreCounter666Seydu")
        {
            gameManager.LoadScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;

            deathScreen.SetActive(true);
        }
    }
}
