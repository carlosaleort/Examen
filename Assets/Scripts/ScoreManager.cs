using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // Referencia al componente de texto de la UI
    private int score = 0;

    void Start()
    {
        UpdateScoreText();
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScoreText();
        HighScoreManager.instance.CheckHighScore(score); // Actualiza la puntuación alta si es necesario
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

}