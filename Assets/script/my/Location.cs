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

 

    //(50.94, 295.80, 2.02)(62.16, 295.80, 2.02)(50.94, 285.23, 2.02)
    //왼:50.94 ,오:, 위: 295.8 ,아래:
    //옆 차이:11.22, 위아래 차이:10.57
}
