using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ImageChange2 : MonoBehaviour
{
    public Image Empty; //시작하는 빈공간
    public Sprite InCorrect; //틀렸을 때 나타나는 빨간 엑스 그림
    public Sprite NotPicture; //아닌 것 같다고 생각하는 엑스 그림(틀린거 아님)
    public Sprite Return; //다시 빈 공간으로
    public GameObject tmp;

    
    public void ChangeImageX()  //그림이 아닌 네모에 적용
    {
        gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        

        if (GameObject.Find("Obutton").GetComponent<BtnActive>().BtnO == 1) //Obutton활성화일때
        {
            Empty.sprite = InCorrect; //틀린 것으로 이미지 바꾸기
            GameObject.Find("HeartCanvas").GetComponent<Heart>().life--;
        }
        else
        {
            if(Empty.sprite != InCorrect) //틀리지 않을 때
            {
                if(Empty.sprite == NotPicture) //다시 돌아가기
                {
                    if(GameObject.Find("Square").GetComponent<Autoo>().finish == 1)
                    {
                        Empty.sprite = NotPicture;
                    }
                    else
                    {
                        gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 0);
                        Empty.sprite = Return;
                    }
                    
                }
                else //엑스 표시하기
                {
                    Empty.sprite = NotPicture;
                }
            }
            
        }

        
    }
}
