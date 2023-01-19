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
   
}
