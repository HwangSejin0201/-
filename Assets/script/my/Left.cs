using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left : MoveControl
{
   
    // Start is called before the first frame update
    public void OnMouseDown()
    {
        SqActive.GetComponent<MoveControl>().IsSelect = 1;
        
        if(SqActive.transform.position.x <= -45f)
        {
            SqActive.transform.position = new Vector3(86.02f, SqActive.transform.position.y, 100.00f);
        }
        else
        {
            SqActive.transform.position += new Vector3(-14.73f, 0, 0);
        }
        
    }
    
}
