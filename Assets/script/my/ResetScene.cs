using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{
    public string SceneName;

    private void Start()
    {
        SceneName=SceneManager.GetActiveScene().name;
    }

 

    public void OnMouseDown()
    {
        SceneManager.LoadScene(SceneName);
    }
}
