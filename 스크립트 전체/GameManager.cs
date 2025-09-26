using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    //GameStart
    public void GoMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    //ResultScene으로
    public static void GoResultScene()
    {
        SceneManager.LoadScene("ResultScene");
    }

    //StartScene으로
    public void GoStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }

    //Game종료
    public void OnClickQuit()
    {
        Application.Quit();
    }

    //게임정지
    public void Stop()
    {
        Time.timeScale = 0f;
       // ExitPanel.SetActive(true);
    }
    
    //게임정지해제
    public void OnClickStart()
    {
        Time.timeScale = 1f;
       // ExitPanel.SetActive(false);
    }
}
