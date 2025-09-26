using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoomEffect : MonoBehaviour
{
    public Sprite Effect1;
    public Sprite Effect2;
    public Sprite Effect3;
    //int Score = GameObject.Find("Score").GetComponent<스크립트명>();
    
    void Start()
    {
        
    }

    //일정 점수가 되면 젤리 변경(원래 200,200,500 점에서 바뀜)
    void Update()
    {
        if(Score_Manager.score >= 10 && Score_Manager.score < 20)
        {
            gameObject.GetComponent<Image>().sprite = Effect1;
            Debug.Log("되냐?");
        }
        else if(Score_Manager.score >= 20 && Score_Manager.score < 50)
        {
            gameObject.GetComponent<Image>().sprite = Effect2;
        }
        else if (Score_Manager.score >= 50)
        {
            gameObject.GetComponent<Image>().sprite = Effect3;
        }
    }
}
