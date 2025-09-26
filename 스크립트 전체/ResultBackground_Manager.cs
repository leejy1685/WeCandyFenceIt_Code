using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultBackground_Manager : MonoBehaviour
{
    public GameObject WinBackground;
    // Start is called before the first frame update
    void Start()
    {
        if (Score_Manager.score > Score_Record.savedScore)  //해당 게임 점수가 최고점수보다 높은 경우, 즉 최고점수가 갱신된 경우
        {
            WinBackground.SetActive(true);
        }
        else
        {
            WinBackground.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
