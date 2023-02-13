using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NumOutline_S2 : MonoBehaviour
{

    public GameObject target;
    public float distance;
    public float distance2;
    public float distance11;
    public float distance22;
    int num;
    int num2;
    List<GameObject> distances = new List<GameObject>();
    List<GameObject> distances2 = new List<GameObject>();

    private void Start()
    {
        target = GameObject.Find("Select");
        GameObject[] tmp = GameObject.FindGameObjectsWithTag("target");
        GameObject[] tmp2 = GameObject.FindGameObjectsWithTag("target2");
        foreach (GameObject go in tmp)
        {
            distances.Add(go);
        }
        foreach (GameObject go in tmp2)
        {
            distances2.Add(go);
        }
        
    }
    private void Update()
    {
        distance = Vector3.Distance(distances[0].transform.position, target.transform.position);
        for (int i = 0; i < distances.Count; i++)
        {
            distance2 = Vector3.Distance(distances[i].transform.position, target.transform.position);
            if (distance >= distance2)
            {
                distance = distance2;
                num = i;
            }
        }
 

        distance11 = Vector3.Distance(distances2[0].transform.position, target.transform.position);
        for (int i = 0; i < distances2.Count; i++)
        {
            distance22 = Vector3.Distance(distances2[i].transform.position, target.transform.position);
            if (distance11 >= distance22)
            {
                distance11 = distance22;
                num2 = i;
            }
        }


        for (int i = 0; i < distances.Count; i++)
        {
            distances[i].GetComponent<Image>().color = new Color(1, 1, 1, 0);
            distances2[i].GetComponent<Image>().color = new Color(1, 1, 1, 0);
        }

        if (GameObject.Find("Select").GetComponent<MoveControlS2>().IsSelect == 1)
        {
            distances[num].GetComponent<Image>().color = new Color(1, 1, 0, 0.3f);
            distances2[num2].GetComponent<Image>().color = new Color(1, 1, 0, 0.3f);
        }

        
    }
    


}
