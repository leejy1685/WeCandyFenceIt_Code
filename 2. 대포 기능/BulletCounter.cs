using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCounter : MonoBehaviour
{
    public GameObject Bullet01;
    public GameObject Bullet02;
    public GameObject Bullet03;
    //폭탄 개수 제한용 변수
    public static int bulletcount = 3;



    void Update()//SetActive true/false는 중첩이 된대요. 부해장님이 짠 코드
    {
        if (bulletcount == 3)
        {
            Bullet03.SetActive(true);
        }
        if (bulletcount == 2)
        {
            Bullet03.SetActive(false);
            Bullet02.SetActive(true);
        }
        if (bulletcount == 1)
        {
            Bullet02.SetActive(false);
            Bullet01.SetActive(true);
        }
        if (bulletcount == 0)
        {
            Bullet01.SetActive(false);
        }
    }
}
