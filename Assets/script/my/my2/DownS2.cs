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
        

        if (SqActive.transform.position.y < 290f)
        {
            SqActive.transform.position = new Vector3(SqActive.transform.position.x, 565.84f,0);
        }
        else
        {
            SqActive.transform.position += new Vector3(0, -20.3f, 0);
        }

    }


}
