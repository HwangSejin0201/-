using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneMove : MonoBehaviour
{
    public void GameSceneCtrl()
    {
        SceneManager.LoadScene("First"); //� ������ �̵��� ����
    }

    public void GameSceneCtrl_2()
    {
        SceneManager.LoadScene("FirstChapter"); //� ������ �̵��� ����
    }

    public void GameSceneCtrl_3()
    {
        SceneManager.LoadScene("Story"); //� ������ �̵��� ����
    }
   
}
