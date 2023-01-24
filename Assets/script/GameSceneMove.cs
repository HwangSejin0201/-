using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneMove : MonoBehaviour
{
    public void GameSceneCtrl()
    {
        SceneManager.LoadScene("Second"); //� ������ �̵��� ����
    }

    public void GameSceneCtrl_2()
    {
        SceneManager.LoadScene("Art"); //� ������ �̵��� ����
    }

    public void GameSceneCtrl_3()
    {
        SceneManager.LoadScene("Story"); //� ������ �̵��� ����
    }
   public void GameSceneCtrl_4()
    {
        SceneManager.LoadScene("FirstChapter"); //� ������ �̵��� ����
    }
    public void GameSceneCrtl_5()
    {
        SceneManager.LoadScene("InGameScene");
    }
}