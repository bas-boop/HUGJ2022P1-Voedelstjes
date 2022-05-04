using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject main;
    [SerializeField] private GameObject story;
    [SerializeField] private GameObject backButton;
    [SerializeField] private GameObject storyButton;

    private void Start()
    {
        //es = GetComponent<EventSystem>().currentSelectedGameObject;
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("PlayerSlecetScreen");
    }

    public void StoryButton()
    {
        main.SetActive(false);
        story.SetActive(true);

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(backButton);
    }

    public void BackButton()
    {
        story.SetActive(false);
        main.SetActive(true);

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(storyButton);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
