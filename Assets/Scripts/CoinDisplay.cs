using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDisplay : MonoBehaviour
{
    public Text scoreCoin;
    public Text bestScore;
    public int score;
    private int totalScore;

    //PlayerPrefs
    //PlayerPrefs.GetInt(keyBestScore);
    //PlayerPrefs.SetInt(keyBestScore, value);
    //keyBestScore
    //Int Float String

    public static CoinDisplay instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        totalScore = PlayerPrefs.GetInt("keyBestScore");

        bestScore.text = totalScore.ToString();

    }

    private void SaveScore()
    {
        if(score > totalScore)
        {
            PlayerPrefs.SetInt("keyBestScore", score);
            bestScore.text = score.ToString();
        }
    }

    // Update is called once per frame
    public void UpdateScore(int value)
    {
        score += value;

        scoreCoin.text = score.ToString();

        SaveScore();
    }
}
