using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    Vector3 pos;
    void Start()
    {
        pos = transform.position;
        Debug.Log(pos);
    }


    //é��1
    //(60.60, 373.59, 11.19)(232.8897, 373.59, 11.19)(60.60, 205.4502, 11.19)
    //�� ����:19.1433, ���Ʒ� ����:18.6822

    //é��2
    //(56.78, 330.71, 2.25)(235.76, 330.71, 2.25)(56.78, 163.53, 2.25)
    //�� ����:12.7842, ���Ʒ� ����:11.9414

    //é��4
    //(53.56, 350.61, 2.25)(237.65, 350.61, 2.25)(53.56, 160.62, 2.25)
    //�� ����:9.6889, ���Ʒ� ����:9.9995
}
