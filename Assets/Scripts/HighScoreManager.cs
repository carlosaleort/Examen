using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreManager : MonoBehaviour
{
    public static HighScoreManager instance;
    public int highScore = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CheckHighScore(int score)
    {
        if (score > highScore)
        {
            highScore = score;
            // Aquí puedes guardar la puntuación alta en PlayerPrefs si lo deseas.
        }
    }
}
