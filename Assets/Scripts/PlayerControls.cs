using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float jumpPower = 6f;
    private bool grounded = false;
    private float startX;
    private Rigidbody2D rb;
    private GameController gameController;

    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        startX = transform.position.x;
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && grounded)
        {
            // Add force to the rigidbody to jump
            rb.AddForce(Vector3.up * (jumpPower * rb.mass * rb.gravityScale * 20.0f));
        }

        if (transform.position.x < startX)
        {
            GameOver();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            grounded = true;
        }
	else if (collision.collider.tag == "Enemy")
        {
            GameOver();
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            grounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            grounded = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Coin")
        {
            gameController.Score++;
            Destroy(collider.gameObject);
        }
    }

    void GameOver()
    {
        gameController.GameOver();
    }
}
