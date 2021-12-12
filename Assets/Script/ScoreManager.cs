using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text currentScoreUI;   // ���� ���ھ� UI
    public Text bestScoreUI;  // �ְ� ���ھ� UI
    public int currentScoreSystem = 0;  // ���� ���ھ�
    public int bestScoreSystem = 0; // �ְ� ���ھ�

    public void setScore(int scoreData)
    {
        currentScoreSystem = scoreData;

        currentScoreUI.text = "���� ���� : " + currentScoreSystem;
        if (currentScoreSystem > bestScoreSystem)
        {
            bestScoreSystem = currentScoreSystem;
            bestScoreUI.text = "�ְ� ���� : " + bestScoreSystem;
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
        bestScoreUI.text = "�ְ� ���� : " + bestScoreSystem;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
