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
        

        if (SqActive.transform.position.y < 164f)
        {
            SqActive.transform.position = new Vector3(SqActive.transform.position.x, 350.61f, SqActive.transform.position.z);
        }
        else
        {
            SqActive.transform.position += new Vector3(0, -9.9995f, 0);
        }

    }


}
