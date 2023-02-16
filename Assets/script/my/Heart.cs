using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    List<GameObject> list = new List<GameObject>();
    public int life; //틀린 개수 세는 장치
    public GameObject fail;
    public GameObject failchild;
    public GameObject success;
    public GameObject successchild;
    List<GameObject> IsEmpty = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        life = 5;
        GameObject[] tmp = GameObject.FindGameObjectsWithTag("Heart");
        foreach (GameObject go in tmp)
        {
            list.Add(go);
        }

        fail = GameObject.Find("Fail");
        failchild = fail.transform.GetChild(0).gameObject;
        failchild.SetActive(false);
        success = GameObject.Find("Success");
        successchild = success.transform.GetChild(0).gameObject;
        successchild.SetActive(false);
    }

    

    // Update is called once per frame
    void Update()
    {   
        
        for (int i = 0; i < (5-life) ; i++)
        {
            list[i].SetActive(false);
        }


        if (life <= 0)
        {

            failchild.SetActive(true);

        }

        IsEmpty = null;

        GameObject[] tmp = GameObject.FindGameObjectsWithTag("square2");
        foreach (GameObject go in tmp)
        {
            IsEmpty.Add(go);
        }

        if (IsEmpty == null)
        {
            successchild.SetActive(true);
        }
    }

   
    
}
