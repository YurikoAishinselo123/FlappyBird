using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    private const string HighScoreKey = "HighScore";

    public void addScore()
    {
        score += 1;
    }

    public void SaveScore()
    {
        if (score > PlayerPrefs.GetInt(HighScoreKey, 0)) 
        {
            PlayerPrefs.SetInt(HighScoreKey, score); 
            PlayerPrefs.Save(); 
        }
    }

    public int GetHighScore()
    {
        return PlayerPrefs.GetInt(HighScoreKey, 0); 
    }

    public void ResetHighScore()
    {
        PlayerPrefs.DeleteKey(HighScoreKey); 
    }
}
