using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    List<GameObject> list = new List<GameObject>();


    public int IsStart=0;
    Vector3 pos;
    public GameObject[] tmp;
    
    public void GoLeft()
    {
        
        if (IsStart == 0)
        {
            this.transform.Translate(new Vector3(54.79f, 330.60f, 0));
            IsStart = 1;
        }
        else
        {
            tmp = GameObject.FindGameObjectsWithTag("target");
            pos = tmp[0].transform.position;
            this.transform.Translate(new Vector3(pos.x-17, pos.y, 0));
            
        }
        
        
    }
}
