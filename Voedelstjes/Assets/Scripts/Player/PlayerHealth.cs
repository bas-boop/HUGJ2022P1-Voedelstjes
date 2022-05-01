using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private GameObject blur;
    [SerializeField] private Color newColor;
    [SerializeField] private GameManger gm;
    
    [Header("VALUE'S")]
    [SerializeField] private int health;
    [SerializeField] private int maxHealth;

    [Header("JAR'S")]
    [SerializeField] private GameObject[] jars;
    [SerializeField] private GameObject currentJar;
    [SerializeField] private GameObject SMaxJar;
    [SerializeField] private GameObject KMaxJar;
    private int _index;

    [Header("PLAYER SPRITE")]
    [SerializeField] private Sprite full;
    [SerializeField] private Sprite damaged;
    private bool isDamaged;

    private void Start()
    {
        gm = GameObject.Find("Gamemanger").GetComponent<GameManger>();
        blur = GameObject.Find("Blur");
        
        FillHealthSprites();
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
            TakeDamage(1);
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            Heal();
        }
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
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

    private void FillHealthSprites()
    {
        if (this.gameObject.name == "StrawberryPlayer(Clone)")
        {
            jars = gm.Sjars;
            
            _index = maxHealth;
            currentJar = jars[_index];
            SMaxJar = jars[maxHealth];
            SMaxJar.SetActive(true);
        }
        else if (this.gameObject.name == "KiwiPlayer(Clone)")
        {
            jars = gm.Kjars;
            
            _index = maxHealth;
            currentJar = jars[_index];
            KMaxJar = jars[maxHealth];
            KMaxJar.SetActive(true);
        }
    }
}
