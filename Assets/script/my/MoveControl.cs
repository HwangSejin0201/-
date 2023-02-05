using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;

public class MoveControl : MonoBehaviour
{
    public int IsSelect;
    public GameObject SqActive;
    public Image Empty; 
    public Sprite Picture;

    // Start is called before the first frame update
    void Start()
    {
        IsSelect = 0;
        SqActive = GameObject.Find("Select");
        SqActive.transform.position = new Vector3(-46.79f, 125.54f, 100);
    }

    // Update is called once per frame
    void Update()
    {
        if(IsSelect == 1)
        {
            SqActive.GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);
            Empty.sprite = Picture;
            
        }
    }
}
