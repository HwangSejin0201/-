using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RightS4 : MoveControlS4
{
    // Start is called before the first frame update
    public void OnMouseDown()
    {
        SqActive.GetComponent<MoveControlS4>().IsSelect = 1;

        if (SqActive.transform.position.x > 233f)
        {
            SqActive.transform.position = new Vector3(53.56f, SqActive.transform.position.y, SqActive.transform.position.z);
        }
        else
        {
            SqActive.transform.position += new Vector3(9.6889f, 0, 0);
        }

    }

    //(88.46, 300.20, 0.00)(105.40, 300.20, 0.00)(105.40, 283.80, 0.00)
    //위아래 차이:16.7 , 옆: 16.94
    //위:333.90 (105.40, 333.90, 0.00) 아래:183.60 (105.40, 183.60, 0.00)오:207.04(207.04, 283.80, 0.00) 왼:54.58 (54.58, 283.80, 0.00)

    // Update is called once per frame
}
