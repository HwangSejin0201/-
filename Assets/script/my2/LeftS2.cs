using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftS2 : MoveControlS2
{
   
    // Start is called before the first frame update
    public void OnMouseDown()
    {
        SqActive.GetComponent<MoveControlS2>().IsSelect = 1;

        if (SqActive.transform.position.x < 61f)
        {
            SqActive.transform.position = new Vector3(235.76f, SqActive.transform.position.y, SqActive.transform.position.z);
        }
        else
        {
            SqActive.transform.position += new Vector3(-12.7842f, 0, 0);
        }


    }

}
