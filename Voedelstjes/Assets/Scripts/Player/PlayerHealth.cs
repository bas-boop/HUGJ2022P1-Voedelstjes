using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private GameObject blur;
    [SerializeField] private Color newColor;
    
    [Header("VALUE'S")]
    [SerializeField] private int health;
    [SerializeField] private int maxHealth;

    [Header("JAR'S")]
    [SerializeField] private GameObject[] jars;
    [SerializeField] private GameObject currentJar;
    [SerializeField] private GameObject maxJar;
    private int _index;

    [Header("PLAYER SPRITE")]
    [SerializeField] private Sprite full;
    [SerializeField] private Sprite damaged;
    private bool isDamaged;

    private void Awake()
    {
        _index = maxHealth;
        currentJar = jars[_index];
        maxJar = jars[maxHealth];
        maxJar.SetActive(true);
    }

    private void Update()
    {
        if (health <= 0)
        {
            Debug.Log("Death");
        }

        if (health <= maxHealth / 2)
        {
            isDamaged = true;
            Debug.Log(isDamaged);

            this.GetComponent<SpriteRenderer>().sprite = damaged;
        }

        if (isDamaged)
        {
            blur.GetComponent<Image>().color = newColor;
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            Heal();
        }
    }

    public void TakeDamage()
    {
        health -= 1;
        if (health < 0)
        {
            health = 0;
        }
        currentJar.SetActive(false);
        _index = health;
        currentJar = jars[_index];
        currentJar.SetActive(true);
    }
    public void Heal()
    {
        health += 1;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
        currentJar.SetActive(false);
        _index = health;
        currentJar = jars[_index];
        currentJar.SetActive(true);
    }
}
