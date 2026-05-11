using System.Collections; // 
using System.Collections.Generic; // 
using UnityEngine; // 

// HealthCollectible class: handles collectible health items
public class HealthCollectible : MonoBehaviour 
{
    /*==== TRIGGER COLLISION: called when another object enters trigger area ==== */
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>(); // try to find RubyController component on the object touching collectible

        if (controller != null) // check if object is actually the player
        {
            if (controller.health < controller.maxHealth) // only heal player if health is NOT full
            {
                controller.ChangeHealth(1); // increase player health by 
                Destroy(gameObject); // remove collectible from scene
            }
        }
    }
}
