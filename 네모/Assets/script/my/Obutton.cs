using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obutton : MonoBehaviour
{
    public Image Active; //활성화 그림
    public Sprite InActive; //비활성화 그림
    public Sprite ReActive; //다시 활성화 그림

    private void Update()
    {
        if (GameObject.Find("Obutton").GetComponent<BtnActive>().BtnO == 1)
        {
            Active.sprite = ReActive; //이미지 바꾸기
            
        }
        else
        {
            Active.sprite = InActive; //이미지 바꾸기
            
        }
    }

    
}
