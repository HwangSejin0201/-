using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Up : MoveControl
{

    // Start is called before the first frame update
    public void OnMouseDown()
    {
        SqActive.GetComponent<MoveControl>().IsSelect = 1;

        if (SqActive.transform.position.y >= 120f)
        {
            SqActive.transform.position = new Vector3(SqActive.transform.position.x, 10.64f, 100.00f);
        }
        else
        {
            SqActive.transform.position += new Vector3(0, 12.76f, 0);
        }

    }

    //(88.46, 300.20, 0.00)(105.40, 300.20, 0.00)(105.40, 283.80, 0.00)
    //���Ʒ� ����:16.7 , ��: 16.94
    //��:333.90 (105.40, 333.90, 0.00) �Ʒ�:183.60 (105.40, 183.60, 0.00)��:207.04(207.04, 283.80, 0.00) ��:54.58 (54.58, 283.80, 0.00)

}
