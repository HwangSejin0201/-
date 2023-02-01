using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;

public class RandomHint : MonoBehaviour
{
    public Image Before;
    public Sprite After;

    public void OnMouseDown()
    {
        if (Before.sprite == After)
        {
            return;
        }

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

                list[rand].tag = "square3";
                list.RemoveAt(rand);
                if(list.Count <= 0)
                {
                    break;
                }

            }
        }
        else
        {
            GameObject.Find("Obutton").GetComponent<BtnActive>().BtnO = 1;
            for (int i = 0; i < 3; i++)
            {
                int rand = Random.Range(0, list.Count);
                list[rand].GetComponent<ImageChange>().ChangeImage();

                list[rand].tag = "square3";
                list.RemoveAt(rand);
                if (list.Count <= 0)
                {
                    break;
                }
            }
            GameObject.Find("Obutton").GetComponent<BtnActive>().BtnO = 0;
        }

        Before.sprite = After;

    }
}
