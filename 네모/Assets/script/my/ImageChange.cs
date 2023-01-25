using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChange : MonoBehaviour
{
    public Image Empty; //시작하는 빈공간
    public Sprite Picture; //네모로직 그림
    public Sprite NotPicture; //아닌 것 같다고 생각하는 엑스 그림(틀린거 아님)
    public Sprite Return; //다시 빈 공간으로


    public void ChangeImage() //그림이 맞는 네모에 적용
    {
        gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        gameObject.tag = "square2";
        /*if (gameObject.tag == "target")
        {
            gameObject.tag = "square";
        }
        GameObject.Find("Move").GetComponent<Move>().IsStart = 1;
        gameObject.tag = "target";*/

        if (GameObject.Find("Obutton").GetComponent<BtnActive>().BtnO == 1) //Obutton활성화일때
        {
            Empty.sprite = Picture; //맞을 때의 이미지
            gameObject.tag = "square3";
        }
        else
        {
            if(Empty.sprite != Picture) //그림을 맞추기 전
            {
                if (Empty.sprite == NotPicture) //다시 돌아가기
                {
                    gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 0);
                    Empty.sprite = Return;
                }
                else
                {
                    Empty.sprite = NotPicture; //엑스 표시하기
                }
            }
        }
        
    }

     
}
