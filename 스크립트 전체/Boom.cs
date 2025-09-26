using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{
    //생성된 후 Boooooom작업 실행 그냥 Start에 넣을 시 오류
    void Start()
    {
        StartCoroutine("Boooooom");
    }

    //0.3후 Destory실행
    IEnumerator Boooooom()
    {
        yield return new WaitForSeconds(0.3f);
        Destroy(this.gameObject);
    }

    //Tag Enemy접촉시 Enemy 삭제
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag=="Enemy")
        {
            //점수 증가
            Destroy(col.gameObject);
            Score_Manager.score += 1;


            //if (col.gameObject == WayPoint.Jelly[0])
            //{
            //    Destroy(col.gameObject);
            //    Score_Manager.score += 1;
            //}
            //else if (col.gameObject == WayPoint.Jelly[1])
            //{
            //    Destroy(col.gameObject);
            //    Score_Manager.score += 2;
            //}
            //else if (col.gameObject == WayPoint.Jelly[2])
            //{
            //    Destroy(col.gameObject);
            //    Score_Manager.score += 3;
            //}
            //else if (col.gameObject == WayPoint.Jelly[3])
            //{
            //    Destroy(col.gameObject);
            //    Score_Manager.score += 5;
            //}

        }
    }
}
