using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextScript2 : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public GameObject text;

    public int num;

    private void Start()
    {

        num = 0;
        text = GameObject.Find("Text");
        text1 = text.transform.GetChild(0).gameObject;
        text2 = text.transform.GetChild(1).gameObject;

        text2.SetActive(false);



    }
    // Start is called before the first frame update
    

    private void Update()
    {
        if(num == 1)
        {
            text1.SetActive(false);
            text.transform.GetChild(1).gameObject.SetActive(true);

        }
        if (num == 2)
        {

            SceneManager.LoadScene("Intro3");
        }
    }

    public void OnMouseDown()
    {
        num++;

    }

  
}
