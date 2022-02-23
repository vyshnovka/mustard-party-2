using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text highscoreText;
    public Text scoreText;

    public static int highscore;
    int score;

    void Awake()
    {
        highscore = PlayerPrefs.GetInt("Highscore", 281);
    }

    void Start()
    {
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
}
