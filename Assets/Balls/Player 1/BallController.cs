using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] float speed = 5f;

    public ScoreController scoreController;

    private Rigidbody2D rb;
    private AudioSource audioSource;
    private SpriteRenderer spriteRenderer;

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

        if (collision.gameObject.CompareTag("Paddle"))
        {
            scoreController.Player1Scored();
        }
    }
}