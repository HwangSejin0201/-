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
        

        if (SqActive.transform.position.y < 215f)
        {
            SqActive.transform.position = new Vector3(SqActive.transform.position.x, 373.59f, SqActive.transform.position.z);
        }
        else
        {
            SqActive.transform.position += new Vector3(0, -18.6822f, 0);
        }

    }


}
