using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OnMouseDown1 : MonoBehaviour
{
    public GameObject GameObject1;
    void Start()
    {
        GameObject1 = GameObject.Find("Select");

    }
    public void OnMouseDown()
    {
        GameObject1.GetComponent<MoveControl>().IsSelect = 0;
    }
}
