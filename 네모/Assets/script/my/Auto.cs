using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;

public class Auto : MonoBehaviour
{
    List<GameObject> listsquare = new List<GameObject>();
    List<GameObject> listsquare2 = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] tmp = GameObject.FindGameObjectsWithTag("square2");
        foreach (GameObject go in tmp)
        {
            listsquare2.Add(go);
        }
        Debug.Log(listsquare2.Count);

        GameObject[] tmp2 = GameObject.FindGameObjectsWithTag("square");
        foreach (GameObject go in tmp2)
        {
            listsquare.Add(go);
        }
        Debug.Log(listsquare.Count);
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void Auto1()
    {
        if (listsquare2[0].tag =="square3"&&
            listsquare2[1].tag == "square3")
        {
            if (GameObject.Find("Obutton").GetComponent<BtnActive>().BtnO == 1)
            {
                GameObject.Find("Obutton").GetComponent<BtnActive>().BtnO = 0;
                listsquare[20].GetComponent<ImageChange2>().ChangeImageX();
                listsquare[21].GetComponent<ImageChange2>().ChangeImageX();
                listsquare[22].GetComponent<ImageChange2>().ChangeImageX();
                listsquare[23].GetComponent<ImageChange2>().ChangeImageX();
                listsquare[24].GetComponent<ImageChange2>().ChangeImageX();
                listsquare[25].GetComponent<ImageChange2>().ChangeImageX();
                listsquare[26].GetComponent<ImageChange2>().ChangeImageX();
                listsquare[27].GetComponent<ImageChange2>().ChangeImageX();
                GameObject.Find("Obutton").GetComponent<BtnActive>().BtnO = 1;
            }
            else
            {
                listsquare[20].GetComponent<ImageChange2>().ChangeImageX();
                listsquare[21].GetComponent<ImageChange2>().ChangeImageX();
                listsquare[22].GetComponent<ImageChange2>().ChangeImageX();
                listsquare[23].GetComponent<ImageChange2>().ChangeImageX();
                listsquare[24].GetComponent<ImageChange2>().ChangeImageX();
                listsquare[25].GetComponent<ImageChange2>().ChangeImageX();
                listsquare[26].GetComponent<ImageChange2>().ChangeImageX();
                listsquare[27].GetComponent<ImageChange2>().ChangeImageX();
            }
            
        }
    }
}
