using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] public ObjectMovementScriptableObject objectMovementValues;

    [SerializeField] private GameObject failUI;

    [SerializeField] private Text highscoreText;
    [SerializeField] private Text scoreText;

    public static int highscore;
    public static int score;

    void Awake()
    {
        highscore = PlayerPrefs.GetInt("Highscore", 0);
    }

    void Start()
    {
        objectMovementValues.runtimeSpeed = objectMovementValues.startSpeed;

        highscoreText.text = highscore.ToString();

        StartCoroutine(AddScore());
    }

    IEnumerator AddScore()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            score++;
            scoreText.text = score.ToString();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Obstacle":
                failUI.SetActive(true);

                if (score > highscore)
                {
                    PlayerPrefs.SetInt("Highscore", score);
                }

                objectMovementValues.runtimeSpeed = 0;

                Invoke("RestartGame", 2.0f);

                break;
            case "Booster":
                score += 10;
                scoreText.text = score.ToString();
                Destroy(collision.gameObject);

                break;
        }
    }

    private void RestartGame()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
