using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left : MoveControl
{
   
    // Start is called before the first frame update
    public void OnMouseDown()
    {
        SqActive.GetComponent<MoveControl>().IsSelect = 1;
        
        if(SqActive.transform.position.x <= 54.58f)
        {
            SqActive.transform.position += new Vector3(152.46f, 0, 0);
        }
        else
        {
            SqActive.transform.position += new Vector3(-16.94f, 0, 0);
        }
        
    }
    
}
