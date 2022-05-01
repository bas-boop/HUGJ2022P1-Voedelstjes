using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllItems : MonoBehaviour
{
    [Header("ITEM'S")]
    [SerializeField] private GameObject slagroom;
    [SerializeField] private GameObject suiker;
    [SerializeField] private GameObject pan;
    [SerializeField] private GameObject bowl;
    [SerializeField] private GameObject campFire;
    
    [Header("BOOLS")]
    [SerializeField] private bool isSlagroom = false;
    [SerializeField] private bool isSuiker = false;
    [SerializeField] private bool isPan = false;
    [SerializeField] private bool isBowl = false;
    [SerializeField] private bool isCampFire = false;
    
    private void Start()
    {
        slagroom = GameObject.Find("Slagroom");
        suiker = GameObject.Find("Suiker");
        pan = GameObject.Find("Pan");
        bowl = GameObject.Find("Bowl");
        campFire = GameObject.Find("CampFire");
    }
    
    private void Update()
    {
        isSlagroom = slagroom.GetComponent<Item>().isPickedup;
        isSuiker = suiker.GetComponent<Item>().isPickedup;
        isPan = pan.GetComponent<Item>().isPickedup;
        isBowl = bowl.GetComponent<Item>().isPickedup;
        isCampFire = campFire.GetComponent<Item>().isPickedup;
        
        if (isSlagroom && isSuiker && isPan && isBowl && isCampFire)
        {
            Debug.Log("You Won!!!");
        }
    }
}
