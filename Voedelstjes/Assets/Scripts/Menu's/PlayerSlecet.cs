using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class PlayerSlecet : MonoBehaviour
{
    public void Strawberry()
    {
        string json = File.ReadAllText(Application.dataPath + "/Json/PlayerSlecet.json");
        Chose load = JsonUtility.FromJson<Chose>(json);

        load.strawberry = true;
        load.kiwi = false;

        string save = JsonUtility.ToJson(load);
        File.WriteAllText(Application.dataPath + "/Json/PlayerSlecet.json", save);
        Debug.Log(json);
        
        SceneManager.LoadScene("Level");
    }
    public void Kiwi()
    {
        string json = File.ReadAllText(Application.dataPath + "/Json/PlayerSlecet.json");
        Chose load = JsonUtility.FromJson<Chose>(json);
        
        load.kiwi = true;
        load.strawberry = false;
        
        string save = JsonUtility.ToJson(load);
        File.WriteAllText(Application.dataPath + "/Json/PlayerSlecet.json", save);
        Debug.Log(json);
        
        SceneManager.LoadScene("Level");
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    class Chose
    {
        public bool strawberry;
        public bool kiwi;
    }
}
