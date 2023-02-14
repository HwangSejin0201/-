using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    List<GameObject> list = new List<GameObject>();
    public int life = 5; //Ʋ�� ���� ���� ��ġ
    private GameObject over;



    // Start is called before the first frame update
    void Start()
    {
        GameObject[] tmp = GameObject.FindGameObjectsWithTag("Heart");
        foreach (GameObject go in tmp)
        {
            list.Add(go);
        }
        
        
    }

    

    // Update is called once per frame
    void Update()
    {   
        
        for (int i = 0; i < (5-life) ; i++)
        {
            list[i].SetActive(false);
            if (i==5) break;
        }
        

    }

    
}
