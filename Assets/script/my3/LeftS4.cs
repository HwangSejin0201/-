using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftS4 : MoveControlS4
{
   
    // Start is called before the first frame update
    public void OnMouseDown()
    {
        SqActive.GetComponent<MoveControlS4>().IsSelect = 1;
        
        if(SqActive.transform.position.x < 57f)
        {
            SqActive.transform.position = new Vector3(237.65f, SqActive.transform.position.y, SqActive.transform.position.z);
        }
        else
        {
            SqActive.transform.position += new Vector3(-9.6889f, 0, 0);
        }
        
    }
    
}
