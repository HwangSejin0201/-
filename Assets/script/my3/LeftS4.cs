using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftS4 : MoveControlS4
{
   
    // Start is called before the first frame update
    public void OnMouseDown()
    {
        SqActive.GetComponent<MoveControlS4>().IsSelect = 1;
        
        if(SqActive.transform.position.x < 62.44f)
        {
            SqActive.transform.position += new Vector3(161f, 0, 0);
        }
        else
        {
            SqActive.transform.position += new Vector3(-11.8f, 0, 0);
        }
        
    }
    
}
