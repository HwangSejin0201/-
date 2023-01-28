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
        

        if (SqActive.transform.position.y <= 183.6f)
        {
            SqActive.transform.position += new Vector3(0, 150.3f, 0);
        }
        else
        {
            SqActive.transform.position += new Vector3(0, -16.7f, 0);
        }

    }


}
