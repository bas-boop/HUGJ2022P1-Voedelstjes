using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Cinemachine;

public class GetPlayer : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera camera;
    
    [SerializeField] private GameObject strawberryPlayer;
    [SerializeField] private GameObject kiwiPlayer;
    
    private bool _isStrawberry;
    private bool _isKiwi;
    
    private void Awake()
    {
        string json = File.ReadAllText(Application.dataPath + "/Json/PlayerSlecet.json");
        Choze load = JsonUtility.FromJson<Choze>(json);

        _isStrawberry = load.strawberry;
        _isKiwi = load.kiwi;
    }

    private void Start()
    {
        if (_isStrawberry)
        {
            camera.Follow = strawberryPlayer.transform;
            Destroy(kiwiPlayer);
        }

        if (_isKiwi)
        {
            camera.Follow = kiwiPlayer.transform;
            Destroy(strawberryPlayer);
        }
    }

    class Choze
    {
        public bool strawberry;
        public bool kiwi;
    }
}
