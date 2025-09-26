using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CastleAttacked : MonoBehaviour
{
    //성벽 체력
    public static int hp;
    public GameObject Jellyboom = null;
    public Sprite castle1;
    public Sprite castle2;
    public Sprite castle3;
    public Sprite castle4;

    //성 내구도 24로 초기화
    public void Start()
    {
        hp = 24;
    }

    public void Update()
    {
        // 성의 내구도가 0일 때 scene 전환
        if (hp == 0)
        {
            GameManager.GoResultScene();
        }
        // 성의 체력이 떨어질 때마다 이미지 변경
        else if (hp == 5)
        {
            gameObject.GetComponent<Image>().sprite = castle1;
        }
        else if (hp == 10)
        {
            gameObject.GetComponent<Image>().sprite = castle2;
        }
        else if (hp == 15)
        {
            gameObject.GetComponent<Image>().sprite = castle3;
        }
        else if (hp == 20)
        {
            gameObject.GetComponent<Image>().sprite = castle4;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //성벽과 Enemy가 닿았을 때 오브젝트 제거, hp - 1
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
            hp -= 1;

            //if (col.gameObject == WayPoint.Jelly[0])
            //{
            //    Destroy(col.gameObject);
            //    hp -= 1;
            //}
            //else if (col.gameObject == WayPoint.Jelly[1])
            //{
            //    Destroy(col.gameObject);
            //    hp -= 2;
            //}
            //else if (col.gameObject == WayPoint.Jelly[2])
            //{
            //    Destroy(col.gameObject);
            //    hp -= 3;
            //}
            //else if (col.gameObject == WayPoint.Jelly[3])
            //{
            //    Destroy(col.gameObject);
            //    hp -= 5;
            //}
        }
    }
}
