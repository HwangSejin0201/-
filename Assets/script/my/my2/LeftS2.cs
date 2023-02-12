using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftS2 : MoveControlS2
{
   
    // Start is called before the first frame update
    public void OnMouseDown()
    {
        SqActive.GetComponent<MoveControlS2>().IsSelect = 1;
        
        if(SqActive.transform.position.x < 98f)
        {
            SqActive.transform.position = new Vector3(401.15f, SqActive.transform.position.y, 0);
        }
        else
        {
            SqActive.transform.position += new Vector3(-21.7f, 0, 0);
        }
        
    }
    
}
