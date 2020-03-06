using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthcollectable : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        rubycontroller controller = other.GetComponent<rubycontroller>();

        if (controller != null)
        {
            if (controller.health < controller.maxHealth)
            {

                controller.ChangeHealth(1);
            } Destroy(gameObject);
        }
    }
}
