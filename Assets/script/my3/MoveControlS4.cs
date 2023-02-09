using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveControlS4 : MonoBehaviour
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
    }

    // Update is called once per frame
    void Update()
    {
        if (IsSelect == 1)
        {
            SqActive.GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);
            Empty.sprite = Picture;
        }
        else
        {
            SqActive.GetComponent<Image>().color = new Color(1, 1, 1, 0);
        }
    }
}
