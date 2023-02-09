using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class DownS4 : MoveControlS4
{
    
    // Start is called before the first frame update
    public void OnMouseDown()
    {
        SqActive.GetComponent<MoveControlS4>().IsSelect = 1;
        

        if (SqActive.transform.position.y <= 147.4f)
        {
            SqActive.transform.position += new Vector3(0, 147.98f, 0);
        }
        else
        {
            SqActive.transform.position += new Vector3(0, -10.8f, 0);
        }

    }


}
