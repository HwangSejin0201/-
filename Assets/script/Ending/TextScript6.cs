using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TextScript6 : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;
    public GameObject text7;
    public GameObject text;

    public int num;

    private void Start()
    {

        num = 0;
        text = GameObject.Find("Text");
        text1 = text.transform.GetChild(0).gameObject;
        text2 = text.transform.GetChild(1).gameObject;
        text3 = text.transform.GetChild(2).gameObject;
        text4 = text.transform.GetChild(3).gameObject;
        text5 = text.transform.GetChild(4).gameObject;
        text6 = text.transform.GetChild(5).gameObject;
        text7 = text.transform.GetChild(6).gameObject;


        text2.SetActive(false);
        text3.SetActive(false);
        text4.SetActive(false);
        text5.SetActive(false);
        text6.SetActive(false);
        text7.SetActive(false);


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
            text3.SetActive(false);
            text.transform.GetChild(3).gameObject.SetActive(true);

        }
        if (num == 4)
        {
            text4.SetActive(false);
            text.transform.GetChild(4).gameObject.SetActive(true);

        }
        if (num == 5)
        {
            text5.SetActive(false);
            text.transform.GetChild(5).gameObject.SetActive(true);

        }
        if (num == 6)
        {
            text6.SetActive(false);
            text.transform.GetChild(6).gameObject.SetActive(true);

        }
        if (num == 7)
        {

            
        }
    }

    public void OnMouseDown()
    {
        num++;

    }

  
}
