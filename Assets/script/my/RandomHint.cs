using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;

public class RandomHint : MonoBehaviour
{
    
    public void OnMouseDown()
    {
        List<GameObject> list = new List<GameObject>();
        GameObject[] tmp = GameObject.FindGameObjectsWithTag("square2");
        foreach (GameObject go in tmp)
        {
            list.Add(go);
        }

        if(GameObject.Find("Obutton").GetComponent<BtnActive>().BtnO == 1)
        {
            for (int i = 0; i < 3; i++)
            {
                int rand = Random.Range(0, list.Count);
                list[rand].GetComponent<ImageChange>().ChangeImage();
                Debug.Log(list.Count);
                list[rand].tag = "square3";
                list.RemoveAt(rand);

            }
        }
        else
        {
            GameObject.Find("Obutton").GetComponent<BtnActive>().BtnO = 1;
            for (int i = 0; i < 3; i++)
            {
                int rand = Random.Range(0, list.Count);
                list[rand].GetComponent<ImageChange>().ChangeImage();
                Debug.Log(list.Count);
                list[rand].tag = "square3";
                list.RemoveAt(rand);

            }
            GameObject.Find("Obutton").GetComponent<BtnActive>().BtnO = 0;
        }

    }
}
