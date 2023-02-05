using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Down : MoveControl
{
    
    // Start is called before the first frame update
    public void OnMouseDown()
    {
        SqActive.GetComponent<MoveControl>().IsSelect = 1;
        

        if (SqActive.transform.position.y <= 15f)
        {
            SqActive.transform.position = new Vector3(SqActive.transform.position.x, 125.54f, 100.00f);
        }
        else
        {
            SqActive.transform.position += new Vector3(0, -12.76f, 0);
        }

    }


}
