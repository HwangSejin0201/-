using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Distance_S4 : MonoBehaviour
{
    public GameObject player1;
    public GameObject target;
    public float distance;
    public float distance2;
    int num;
    List<GameObject> distances = new List<GameObject>();

    private void Start()
    {
        target = GameObject.Find("Select");
        GameObject[] tmp = GameObject.FindGameObjectsWithTag("square");
        GameObject[] tmp2 = GameObject.FindGameObjectsWithTag("square2");
        foreach (GameObject go in tmp)
        {
            distances.Add(go);
        }
        foreach (GameObject go in tmp2)
        {
            distances.Add(go);
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

    }

    public void OnMouseDown()
    {
        if(GameObject.Find("Select").GetComponent<MoveControlS4>().IsSelect == 1)
        {
            if (distances[num].tag == "square")
            {
                distances[num].gameObject.GetComponent<ImageChange2_S4>().ChangeImageX();
            }
            if (distances[num].tag == "square2")
            {
                distances[num].gameObject.GetComponent<ImageChange>().ChangeImage();
            }
        }
          
    }


}
