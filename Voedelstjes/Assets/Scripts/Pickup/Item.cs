using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool isPickedup = false;
    [SerializeField] private GameObject UI;

    private void Awake()
    {
        UI = GameObject.Find(this.gameObject.name + "UI");
        UI.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            isPickedup = true;
            Debug.Log(isPickedup);
            
            Destroy(this.GetComponent<BoxCollider2D>());
            Destroy(this.GetComponent<SpriteRenderer>());
        }
    }

    private void Update()
    {
        if (isPickedup)
        {
            UI.SetActive(true);
        }
    }
}
