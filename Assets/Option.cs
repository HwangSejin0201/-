using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour
{
    public GameObject OptionPanal;

    public void Option11()
    {
        if (OptionPanal.active == false)
        {
            OptionPanal.SetActive(true);
        }
        else
            OptionPanal.SetActive(false);
    }

    void Start()
    {
        Option11();
    }

}
