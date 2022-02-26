using UnityEngine;
using UnityEngine.UI;

public class StateManager : MonoBehaviour
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Obstacle":
                failUI.SetActive(true);

                if (ScoreManager.score > ScoreManager.highscore)
                {
                    PlayerPrefs.SetInt("Highscore", ScoreManager.score);
                }

                Time.timeScale = 0;

                break;
            case "Booster":
                ScoreManager.score += 10;

                break;
        }
    }
}
