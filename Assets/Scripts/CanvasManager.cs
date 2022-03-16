using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private GameObject menuUI;
    [SerializeField] private GameObject gameplayUI;
    [SerializeField] private GameObject failUI;

    [SerializeField] private Button startButton;
    [SerializeField] private Button exitButton;

    void Start()
    {
        gameplayUI.SetActive(false);
        failUI.SetActive(false);

        Time.timeScale = 0;

        startButton.GetComponent<Button>().onClick.AddListener(StartGame);
        exitButton.GetComponent<Button>().onClick.AddListener(ExitGame);
    }

    void StartGame()
    {
        menuUI.SetActive(false);
        gameplayUI.SetActive(true);

        Time.timeScale = 1;
    }

    void ExitGame()
    {
        Application.Quit();
    }
}
