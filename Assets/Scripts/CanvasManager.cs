using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public GameObject menuUI;

    public Button startButton;
    public Button exitButton;

    void Start()
    {
        Time.timeScale = 0;
        startButton.GetComponent<Button>().onClick.AddListener(StartGame);
        exitButton.GetComponent<Button>().onClick.AddListener(ExitGame);
    }

    void StartGame()
    {
        menuUI.SetActive(false);
        Time.timeScale = 1;
    }

    void ExitGame()
    {
        Application.Quit();
    }
}
