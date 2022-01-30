using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public Button startButton;
    public Button exitButton;

    void Start()
    {
        startButton.GetComponent<Button>().onClick.AddListener(StartGame);
        exitButton.GetComponent<Button>().onClick.AddListener(ExitGame);
    }

    void StartGame()
    {

    }

    void ExitGame()
    {
        Debug.Log("gg wp");
        Application.Quit();
    }
}
