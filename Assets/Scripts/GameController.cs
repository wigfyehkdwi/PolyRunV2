using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public Text scoreText;
    int score = 0;

    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
            if (scoreText != null) scoreText.text = score.ToString();
        }
    }

    public void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        scoreText.gameObject.SetActive(false);
        gameOverPanel.SetActive(true);
    }
}
