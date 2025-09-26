using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonControl : MonoBehaviour
{
    //포탄 변수 생성
    public GameObject Bullet;
    //카메라 변수 생성(좌표값을 월드좌표로 변경하기위한 변수)
    public Camera camera;
    //포탄이 생성되는 곳
    public Transform transform;
    //마우스로 찍은 위치
    Vector2 MousePosition;
   

    IEnumerator CountStart()//폭탄 재장전 코루틴
    {
        yield return new WaitForSeconds(2.0f);
        BulletCounter.bulletcount++;
        //Debug.Log(BulletCounter.bulletcount);
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))// 좌클릭
        {
            //마우스로 찍은 좌표를 월드 좌표로 바꾸는 과정(하지 않을 시 해상도 좌표가 입력됨)
            MousePosition = Input.mousePosition;
            Vector3 temp;
            temp= camera.ScreenToWorldPoint(MousePosition);
            temp.z = 0;
            if (BulletCounter.bulletcount>0)//장전된 폭탄이 0개가 아닌 경우
            {
                //포탄 생성
                GameObject gotemp = Instantiate(Bullet, transform.position, Quaternion.identity);
                //Bullet스크립트에 있는 Setinit함수 사용
                gotemp.GetComponent<Bullet>().Setinit(temp);
                BulletCounter.bulletcount--;//장전된 폭탄 1개 감소
                StartCoroutine("CountStart");  //폭탄 재장전 코루틴 시작
            }
        }
    }
}
