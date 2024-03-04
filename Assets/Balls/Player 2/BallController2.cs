using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BallController2 : MonoBehaviour
{
    [SerializeField] float speed = 5f;

    public ScoreController scoreController;
    public ScoreController2 scoreController2;
    public GameOver gameOver;

    private Rigidbody2D rb;
    private AudioSource audioSource;
    private SpriteRenderer spriteRenderer;
    private bool gameEnded = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Get a reference to the RigidBody
        audioSource = GetComponent<AudioSource>(); //Get a reference to our AudioSource
        spriteRenderer = GetComponent<SpriteRenderer>(); // Get a reference to the SpriteRenderer

        // Set a random direction while maintaining the speed
        Vector2 randomDirection = Random.insideUnitCircle.normalized;
        rb.velocity = randomDirection * speed;
    }

    // Update is called once per frame
    void Update()
    {
        // Maintain speed by normalizing velocity every frame
        rb.velocity = rb.velocity.normalized * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource audioSource; //Delcare a AudioSource reference variable
        audioSource = GetComponent<AudioSource>(); //Get a reference to our AudioSource
        audioSource.Play();

        if (!gameEnded && collision.gameObject.CompareTag("Paddle"))
        {
            scoreController2.Player2Scored();
            if (scoreController.player1Score == 50 || scoreController2.player2Score == 50)
            {
                EndGame();
            }
        }
    }

    void EndGame()
    {
        gameEnded = true;

        //Show the Game Over text
        gameOver.ShowGameOver();
    }
}
