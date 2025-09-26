using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //이동을 위한 리지드바디
    public Rigidbody2D rigidbody2D;
    //마우스로 찍은곳 좌표를 받기위한 스크립트 변수 생성
    CannonControl cannon;
    //마우스로 찍은곳 좌표가 저장될 곳
    private Vector3 temp;
    //포탄의 실시간 위치
    public Transform Transform;
    //포탄이 터진곳에 생성되는 폭발범위 현재 스케일이 (2,2,2)
    public GameObject Boom;
    

    void Update()
    {
        //좌표를 받는 중
        this.Transform = Transform;
        this.temp = temp;

        Debug.Log(temp);
        Debug.Log(Transform.transform.position);
        //마우스로 찍은 곳에 도달 하였을때
        if (Transform.position == temp)
        {
            //포탄 삭제
            Destroy(this.gameObject);
            //폭발 생성
            Instantiate(Boom, Transform.position, Quaternion.identity);
        }
    }

    public void Setinit(Vector3 temp)
    {
        //마우스를 찍은 좌표
        this.temp = temp;
        //그곳으로 이동 곱셈을 소수로 고칠경우 오류가 생길 수 있음
        rigidbody2D.velocity = new Vector2(temp.x*2, (temp.y+3)*2);
    }
}