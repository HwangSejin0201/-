using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnActive2 : MonoBehaviour
{
        
    public void OnMouseDown()
    {
        
        GameObject.Find("Obutton").GetComponent<BtnActive>().BtnO = 0;
        
    }
}
