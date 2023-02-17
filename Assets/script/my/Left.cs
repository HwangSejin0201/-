using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left : MoveControl
{
   
    // Start is called before the first frame update
    public void OnMouseDown()
    {
        SqActive.GetComponent<MoveControl>().IsSelect = 1;
        
        if(SqActive.transform.position.x < 70f)
        {
            SqActive.transform.position = new Vector3(232.8897f, SqActive.transform.position.y, SqActive.transform.position.z);
        }
        else
        {
            SqActive.transform.position += new Vector3(-19.1433f, 0, 0);
        }
        
    }
    
}
