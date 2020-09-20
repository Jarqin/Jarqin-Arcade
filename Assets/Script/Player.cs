using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

	public float speed = 4f;
    public Rigidbody2D rb;
    private float movement = 0f;
    public GameObject gameOver;
    public GameObject gameOverSound;    

    void Update()
    {
        Time.timeScale = 1;
    	movement = Input.GetAxisRaw("Horizontal") * speed;
    }

    void FixedUpdate()
    {
    	rb.MovePosition(rb.position + new Vector2 (movement * Time.fixedDeltaTime, 0f));
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.collider.tag == "Ball")
        {
            Instantiate(gameOverSound, transform.position, Quaternion.identity);
            Debug.Log("Game Over");
            gameOver.SetActive(true);
            Time.timeScale = 0;
        }
    }

}
