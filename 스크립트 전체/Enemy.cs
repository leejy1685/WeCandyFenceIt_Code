using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    //젤리 터진 흔적
    public GameObject Jellyboom = null;
    // 이동 속도
    public float moveSpeed = 3.0f;
    //물체이동을 위한 리지드바디 변수 생성
    public Rigidbody2D rigidbody2D;


    void FixedUpdate()
    {
        //-y 방향으로 이동
        rigidbody2D.velocity = new Vector2(0, -moveSpeed);

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag=="Boom")
        {
            GameObject Deadjelly = Instantiate(Jellyboom, transform.position, Quaternion.identity);//젤리 터진 흔적 생성
            Destroy(Deadjelly, 1.0f);//1초 후 제거. 
        }
    }


}

