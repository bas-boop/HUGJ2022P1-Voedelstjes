using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    [Header("PLAYER")]
    [SerializeField] private GameObject player;
    
    [Header("JAR'S")]
    public GameObject[] Sjars;
    public GameObject[] Kjars;

    [Header("TIMER")]
    [SerializeField] private float otherPlayerTime;
    [SerializeField] private float strawberryTime;
    [SerializeField] private float kiwiTime;
    
    [Header("BLUR")]
    [SerializeField] private GameObject blur;
    [SerializeField] private Color beginColor;
    [SerializeField] private float blurTime;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        if (player.name == "StrawberryPlayer(Clone)")
        {
            otherPlayerTime = strawberryTime;
        }
        else if (player.name == "KiwiPlayer(Clone)")
        {
            otherPlayerTime = kiwiTime;
        }
        
        blur = GameObject.Find("Blur");
        blur.GetComponent<Image>().color = beginColor;
    }

    private void Update()
    {
        otherPlayerTime -= Time.deltaTime;
        
        if (player.name == "StrawberryPlayer(Clone)")
        {
            blurTime = 1 + otherPlayerTime / -strawberryTime;
            if (otherPlayerTime <= 0)
            {
                Debug.Log("Andere player heeft gewonnen!!!");
                SceneManager.LoadScene("StrawberryLose");
            }
        }
        else if (player.name == "KiwiPlayer(Clone)")
        {
            blurTime = 1 + otherPlayerTime / -kiwiTime;
            if (otherPlayerTime <= 0)
            {
                Debug.Log("Andere player heeft gewonnen!!!");
                SceneManager.LoadScene("KiwiLose");
            }
        }
        
        blur.GetComponent<Image>().color = new Color(0, 0, 0, blurTime);
    }
}
