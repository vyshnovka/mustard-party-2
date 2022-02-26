using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
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
