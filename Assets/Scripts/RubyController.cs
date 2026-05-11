using System.Collections; // allows use of basic collection
using System.Collections.Generic; // allows use of generic collection
using UnityEngine; // import Unity engine functions/classes

// RubyController: controls player movement, health, and invincibility
public class RubyController : MonoBehaviour
{
    /* ==== PLAYER SETTING ==== */
    public float speed = 3.0f; // player movement speed

    public int maxHealth = 5; // max player health
    public float timeInvincible = 2.0f; // how long player stays invincible after damage

    /* ==== HEALTH SYSTEM: public read-only health property, other scripts can READ health, but not modify ==== */
    public int health { get { return currentHealth; } } 
    
    int currentHealth; // actual current health value

    /* ==== INVINCIBILITY SYSTEM ==== */
    bool isInvincible; // prevents repeated damage spam
    float invincibleTimer; // countdown timer for invincibility 

    /* ==== MOVEMENT VARIABLE ==== */
    Rigidbody2D rigidbody2d; // reference to Rigidbody2D component
    float horizontal; // horizontal movement input
    float vertical; // vertical movement input

    /* ==== START: called once when game starts ==== */
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>(); // get Rigidbody2D component attached to player
        currentHealth = maxHealth; // start player at max health
    }

    /* ==== UPDATE: called every frame ==== */
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal"); // get horizontal keyboard input (A/D or Left/Right Arrows)
        vertical = Input.GetAxis("Vertical"); // get vertical keyboard input (W/S or Up/Down Arrows)

        if (isInvincible) // If player is currently invincible
        {
            invincibleTimer -= Time.deltaTime; // reduce invincibility timer
            if (invincibleTimer < 0) // when timer ends
                isInvincible = false; // disable invincibility
        }
    }

    /* ==== PHYSICS MOVEMENT: called at first intervals. used for physics movement ==== */
    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position; // get current player position
        position.x = position.x + speed * horizontal * Time.deltaTime; // move horizontally
        position.y = position.y + speed * vertical * Time.deltaTime; //  move vertically

        rigidbody2d.MovePosition(position); // move Rigidbody to new position
    }

    /* ==== HEALTH CHANGES: handles healing and damage ==== */
    public void ChangeHealth(int amount)
    {
        if (amount < 0) // if taking damage
        {
            if (isInvincible) // ignore damage while invincible
                return; 

            isInvincible = true; // enable invincibility
            invincibleTimer = timeInvincible; // reset invincibility timer
        }
        // Clamp health value, prevents below 0 or above maxHealth
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth); // print current health into Unity Console
    }
}
