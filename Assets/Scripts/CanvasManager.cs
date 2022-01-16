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
        startButton.GetComponent<Button>().onClick.AddListener(startGame);
        exitButton.GetComponent<Button>().onClick.AddListener(exitGame);
    }

    void startGame()
    {

    }

    void exitGame()
    {
        Debug.Log("gg wp");
        Application.Quit();
    }
}
