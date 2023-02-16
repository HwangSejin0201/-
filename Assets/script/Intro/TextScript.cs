using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TextScript : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text;


    public int num;

    private void Start()
    {

        num = 0;
        text = GameObject.Find("Text");
        text1 = text.transform.GetChild(0).gameObject;
        text2 = text.transform.GetChild(1).gameObject;
        text3 = text.transform.GetChild(2).gameObject;

        text2.SetActive(false);
        text3.SetActive(false);


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
            text2.SetActive(false);
            text.transform.GetChild(2).gameObject.SetActive(true);

        }
        if (num == 3)
        {
            SceneManager.LoadScene("Intro2");
        }
    }

    public void OnMouseDown()
    {
        num++;

    }

   
}
