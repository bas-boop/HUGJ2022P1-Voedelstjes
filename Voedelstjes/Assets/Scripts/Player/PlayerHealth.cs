using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int health;

    private void Update()
    {
        if (health <= 0)
        {
            Debug.Log("Death");
        }
        controlHealth();
        
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            Heal();
        }*/
    }

    public void TakeDamage()
    {
        health -= 1;
        Debug.Log(health);
    }
    public void Heal()
    {
        health += 1;
        Debug.Log(health);
    }

    private void controlHealth()
    {
        if (health > 3)
        {
            health = 3;
        }
        if (health < 0)
        {
            health = 0;
        }
    }
}
