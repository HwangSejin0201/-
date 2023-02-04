using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class DownS2 : MoveControlS2
{
    
    // Start is called before the first frame update
    public void OnMouseDown()
    {
        SqActive.GetComponent<MoveControlS2>().IsSelect = 1;
        

        if (SqActive.transform.position.y <= 147.4f)
        {
            SqActive.transform.position += new Vector3(0, 147.98f, 0);
        }
        else
        {
            SqActive.transform.position += new Vector3(0, -10.6f, 0);
        }

    }


}
