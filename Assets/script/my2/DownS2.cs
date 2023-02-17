using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class DownS2 : MoveControlS2
{
    
    // Start is called before the first frame update
    public void OnMouseDown()
    {
        SqActive.GetComponent<MoveControlS2>().IsSelect = 1;


        if (SqActive.transform.position.y < 168f)
        {
            SqActive.transform.position = new Vector3(SqActive.transform.position.x, 330.71f, SqActive.transform.position.z);
        }
        else
        {
            SqActive.transform.position += new Vector3(0, -11.9414f, 0);
        }


    }


}
