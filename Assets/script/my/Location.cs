using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    Vector3 pos;
    void Start()
    {
        pos = transform.position;
        Debug.Log($"{pos}");
    }

 

    //(50.94, 295.80, 2.02)(62.16, 295.80, 2.02)(50.94, 285.23, 2.02)
    //��:50.94 ,��:, ��: 295.8 ,�Ʒ�:
    //�� ����:11.22, ���Ʒ� ����:10.57
}
