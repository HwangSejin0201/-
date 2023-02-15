using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controler : MonoBehaviour
{
    List<GameObject> listsquare1 = new List<GameObject>();



    void Start()
    {
        GameObject[] tmp = GameObject.FindGameObjectsWithTag("square3");
        foreach (GameObject go in tmp)
        {
            listsquare1.Add(go);
        }

        for (int i = 0; i < listsquare1.Count; i++)
        {
            listsquare1[i].tag = "square2";
        }

 
        

    }
    
}
