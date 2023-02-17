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


    //챕터1
    //(60.60, 373.59, 11.19)(232.8897, 373.59, 11.19)(60.60, 205.4502, 11.19)
    //옆 차이:19.1433, 위아래 차이:18.6822

    //챕터2
    //(56.78, 330.71, 2.25)(235.76, 330.71, 2.25)(56.78, 163.53, 2.25)
    //옆 차이:12.7842, 위아래 차이:11.9414

    //챕터4
    //(53.56, 350.61, 2.25)(237.65, 350.61, 2.25)(53.56, 160.62, 2.25)
    //옆 차이:9.6889, 위아래 차이:9.9995
}
