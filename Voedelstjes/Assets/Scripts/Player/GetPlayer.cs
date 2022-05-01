using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Cinemachine;
using UnityEngine.Events;

public class GetPlayer : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera camera;
    
    [SerializeField] private GameObject strawberryPlayer;
    [SerializeField] private GameObject kiwiPlayer;

    [SerializeField] private GameObject strawberryJar;
    [SerializeField] private GameObject kiwiJar;
    
    private bool _isStrawberry;
    private bool _isKiwi;
    
    private void Awake()
    {
        string json = File.ReadAllText(Application.dataPath + "/Json/PlayerSlecet.json");
        Choze load = JsonUtility.FromJson<Choze>(json);

        _isStrawberry = load.strawberry;
        _isKiwi = load.kiwi;
        
        if (_isStrawberry)
        {
            GameObject s = Instantiate(strawberryPlayer);
            camera.Follow = s.transform;
            camera.LookAt = s.transform;
        }

        if (_isKiwi)
        {
            GameObject k = Instantiate(kiwiPlayer);
            camera.Follow = k.transform;
            camera.LookAt = k.transform;
        }
    }

    class Choze
    {
        public bool strawberry;
        public bool kiwi;
    }
}
