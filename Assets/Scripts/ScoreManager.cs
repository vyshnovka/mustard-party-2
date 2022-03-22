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

    private Animator anim;

    public static int highscore;
    public static int score;

    private Coroutine scoreRoutine = null;

    void Awake()
    {
        highscore = PlayerPrefs.GetInt("Highscore", 0);
    }

    void Start()
    {
        anim = GetComponent<Animator>();

        objectMovementValues.runtimeSpeed = objectMovementValues.startSpeed;

        highscoreText.text = highscore.ToString();

        scoreRoutine = StartCoroutine(AddScore());
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

                StopCoroutine(scoreRoutine);
                objectMovementValues.runtimeSpeed = 0;

                Invoke("RestartGame", 2.0f);

                break;
            case "Booster":
                anim.SetTrigger("Score");
                //anim.ResetTrigger("Score");

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
