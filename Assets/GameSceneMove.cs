using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneMove : MonoBehaviour
{
    public void GameSceneCtrl()
    {
        SceneManager.LoadScene("Second"); //어떤 씬으로 이동할 건지
    }

    public void GameSceneCtrl_2()
    {
        SceneManager.LoadScene("Art"); //어떤 씬으로 이동할 건지
    }

    public void GameSceneCtrl_3()
    {
        SceneManager.LoadScene("Story"); //어떤 씬으로 이동할 건지
    }

   
}
