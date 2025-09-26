using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Record : MonoBehaviour
{
    public Text scoreText;
    public Text bestScoreText;

    public static int savedScore = 0;  //ResultBackground_Manager.cs에서 ResultScene배경 결정을 위해 public 정적 변수로 수정합니다.
    private string KeyString = "BestScore";
    
    void Awake()
    {
        savedScore = PlayerPrefs.GetInt(KeyString, 0); //최고점수 불러오기
        bestScoreText.text = savedScore.ToString();
    }

    
    void Update()
    {
        scoreText.text = Score_Manager.score.ToString();
        if(Score_Manager.score > savedScore)
        {
            PlayerPrefs.SetInt(KeyString, Score_Manager.score);
            PlayerPrefs.Save();
            bestScoreText.text = Score_Manager.score.ToString();
        }
    }
}
