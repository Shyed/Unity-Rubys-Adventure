using System.Collections; // allows use of basic collections like lists
using System.Collections.Generic; // allows use of generic collections
using UnityEngine; // import Unity game engine functions/classes

// DamageZone Class: handles areas that damage the player
public class DamageZone : MonoBehaviour
{
    // Called contiously while another object stays inside this trigger area
    void OnTriggerStay2D(Collider2D other)
    {
        // Try to find RubyController component on the object touching the damage zone
        RubyController controller = other.GetComponent<RubyController>();

        // Check if object actually has RubyController: prevents NPO touch triggers
        if (controller != null)
        {
            // reduce player health by 1
            controller.ChangeHealth(-1);
        }
    }
}
