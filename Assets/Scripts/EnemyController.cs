using System.Collections; // allows use of basic collections
using System.Collections.Generic; // allows use of generic collections
using UnityEngine; // import Unity engine functions/class

// EnemyController class: controls enemy movement and player damage
public class EnemyController : MonoBehaviour
{
    public float speed; // enemy movement speed
    public bool vertical; // determines movement direction: T = vertical, F = horizontal
    public float changeTime = 3.0f; // time before enemy changes direction

    Rigidbody2D rigidbody2D; // reference to enemy Rigidbody2D component
    float timer; // countdown timer
    int direction = 1; // movement direction: 1 = forward, -1 = backward

    /* ==== START: Called once when game starts ==== */
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>(); // Get Rigidbody2D component attached to enemy    
        timer = changeTime;  // Set timer to starting changeTime value
    }

    /* ==== UPDATE: called every frame ==== */
    void Update()
    {
        timer -= Time.deltaTime; // reduce timer over time, Time.deltaTime ensures smooth timing

        if (timer < 0) // when timer reaches 0
        {
            direction = -direction; // reverse movement direction 1 -> -1, -1 -> 1
            timer = changeTime; // reset timer
        }
    }

    /* ==== FIXED UPDATE: called t fixed intervals. Used for physical movement ==== */
    void FixedUpdate()
    {
        Vector2 position = rigidbody2D.position; // get current enemy position

        if (vertical) // vertical movement  
        {
            position.y = position.y + Time.deltaTime * speed * direction; // move enemy up/down
        }
        else // horizontal movement
        {
            position.x = position.x + Time.deltaTime * speed * direction;  // move enemy left/right
        }

        rigidbody2D.MovePosition(position); // move rigidbody to new position
    }

    /* ==== PLAYER COLLISION: called when enemy collides with another object ==== */
    void OnCollisionEnter2D(Collision2D other)
    {
        RubyController player = other.gameObject.GetComponent<RubyController>(); 

        if (player != null) // if collided object is player
        { 
            player.ChangeHealth(-1); // damage player health
        }
    }
}
