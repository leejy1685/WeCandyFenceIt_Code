using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text;
using UnityEngine.UI;

public class WayPoint : MonoBehaviour
{                                                                                                                                                
    //Enemy 스폰 위치 5곳
    [SerializeField]
    GameObject[] Jelly = new GameObject[4];
    Vector3 spawnPoint;
    Vector3 spawnPoint1 = new Vector3(-2.0f,5.0f,0.0f);
    Vector3 spawnPoint2 = new Vector3(-1.0f, 5.0f, 0.0f);
    Vector3 spawnPoint3 = new Vector3(0.0f, 5.0f, 0.0f);
    Vector3 spawnPoint4 = new Vector3(1.0f, 5.0f, 0.0f);
    Vector3 spawnPoint5 = new Vector3(2.0f, 5.0f, 0.0f);

    //SpawnStart 작업 실행 그냥 Start에 넣을 시 오류
    void Start()
    {
        StartCoroutine("SpawnStart");
    }

    //반복문에 넣어 계속 실행 랜덤함수로 수를 받은 후 if문으로 위치 선정
    IEnumerator SpawnStart()
    {
        while (true)
        {
            //스폰위치 랜덤으로 설정
            int random = Random.Range(1, 6);

            //점수에 따른 랜덤젤리 생성
            if (0 <= Score_Manager.score && Score_Manager.score < 10)
            {
                //곰돌이 젤리
                if (random == 1)
                    SetEnemyPosition(spawnPoint1, 0);
                else if (random == 2)
                    SetEnemyPosition(spawnPoint2, 0);
                else if (random == 3)
                    SetEnemyPosition(spawnPoint3, 0);
                else if (random == 4)
                    SetEnemyPosition(spawnPoint4, 0);
                else if (random == 5)
                    SetEnemyPosition(spawnPoint5, 0);
            }

            else if (10 <= Score_Manager.score && Score_Manager.score < 20)
            {
                //곰돌이, 햄스터 젤리
                if (random == 1)
                    SetEnemyPosition(spawnPoint1, 1);
                else if (random == 2)
                    SetEnemyPosition(spawnPoint2, 1);
                else if (random == 3)
                    SetEnemyPosition(spawnPoint3, 1);
                else if (random == 4)
                    SetEnemyPosition(spawnPoint4, 1);
                else if (random == 5)
                    SetEnemyPosition(spawnPoint5, 1);
            }

            else if (20 <= Score_Manager.score && Score_Manager.score < 50)
            {
                //곰돌이, 햄스터, 토끼 젤리
                if (random == 1)
                    SetEnemyPosition(spawnPoint1, 2);
                else if (random == 2)
                    SetEnemyPosition(spawnPoint2, 2);
                else if (random == 3)
                    SetEnemyPosition(spawnPoint3, 2);
                else if (random == 4)
                    SetEnemyPosition(spawnPoint4, 2);
                else if (random == 5)
                    SetEnemyPosition(spawnPoint5, 2);
            }
            else if (50 <= Score_Manager.score)
            {
                //곰돌이, 햄스터, 토끼, 킹콩 젤리
                if (random == 1)
                    SetEnemyPosition(spawnPoint1, 3);
                else if (random == 2)
                    SetEnemyPosition(spawnPoint2, 3);
                else if (random == 3)
                    SetEnemyPosition(spawnPoint3, 3);
                else if (random == 4)
                    SetEnemyPosition(spawnPoint4, 3);
                else if (random == 5)
                    SetEnemyPosition(spawnPoint5, 3);
            }
            //1초 딜레이
            yield return new WaitForSeconds(1.0f);
        }
    }

    #region 스폰 함수
    public void SetEnemyPosition(Vector3 position, int i)
    {
        spawnPoint = position;
        Spawn(spawnPoint, i);
    }

    GameObject Spawn(Vector3 position, int i)
    {
        //젤리 0번째 부터 i 번째까지 랜덤
        return Instantiate(Jelly[Random.Range(0, i)], position, Quaternion.identity);

    }
    #endregion
}
