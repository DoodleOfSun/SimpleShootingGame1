using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text currentScoreUI;   // 현재 스코어 UI
    public Text bestScoreUI;  // 최고 스코어 UI
    public int currentScoreSystem = 0;  // 현재 스코어
    public int bestScoreSystem = 0; // 최고 스코어

    public void setScore(int scoreData)
    {
        currentScoreSystem = scoreData;

        currentScoreUI.text = "현재 점수 : " + currentScoreSystem;
        if (currentScoreSystem > bestScoreSystem)
        {
            bestScoreSystem = currentScoreSystem;
            bestScoreUI.text = "최고 점수 : " + bestScoreSystem;
            PlayerPrefs.SetInt("BestScore", bestScoreSystem);
        }
    }

    public int getScore()
    {
        return currentScoreSystem;
    }

    void Start()
    {
        bestScoreSystem = PlayerPrefs.GetInt("BestScore", 0);
        bestScoreUI.text = "최고 점수 : " + bestScoreSystem;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
