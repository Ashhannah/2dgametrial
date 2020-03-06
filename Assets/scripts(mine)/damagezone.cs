using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damagezone : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        rubycontroller controller = other.GetComponent<rubycontroller >();

        if (controller != null)
        {
            controller.ChangeHealth(-1);
        }


    }
        
    void OnColisionEnter2D(Collision2D other)
    {
        rubycontroller player = other.gameObject.GetComponent<rubycontroller>();

        if (player != null)
        {
            player.ChangeHealth(-1);
            }
    }
}
