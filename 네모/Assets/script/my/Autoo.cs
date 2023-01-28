using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autoo : MonoBehaviour
{
    public int finish = 0;

    //오브젝트와 배열 선언
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;
    public GameObject seven;
    public GameObject eight;
    public GameObject nine;
    public GameObject ten;
    public GameObject tmp;

    public GameObject[] array1 = new GameObject[10];
    public GameObject[] array2 = new GameObject[10];
    public GameObject[] array3 = new GameObject[10];
    public GameObject[] array4 = new GameObject[10];
    public GameObject[] array5 = new GameObject[10];
    public GameObject[] array6 = new GameObject[10];
    public GameObject[] array7 = new GameObject[10];
    public GameObject[] array8 = new GameObject[10];
    public GameObject[] array9 = new GameObject[10];
    public GameObject[] array10 = new GameObject[10];
    public GameObject[] array11 = new GameObject[10];
    public GameObject[] array12 = new GameObject[10];
    public GameObject[] array13 = new GameObject[10];
    public GameObject[] array14 = new GameObject[10];
    public GameObject[] array15 = new GameObject[10];
    public GameObject[] array16 = new GameObject[10];
    public GameObject[] array17 = new GameObject[10];
    public GameObject[] array18 = new GameObject[10];
    public GameObject[] array19 = new GameObject[10];
    public GameObject[] array20 = new GameObject[10];


    void Start()
    {
        tmp = GameObject.Find("Obutton");
        // 부모 오브젝트 찾기
        one = GameObject.FindGameObjectWithTag("line1");
        two = GameObject.FindGameObjectWithTag("line2");
        three = GameObject.FindGameObjectWithTag("line3");
        four = GameObject.FindGameObjectWithTag("line4");
        five = GameObject.FindGameObjectWithTag("line5");
        six = GameObject.FindGameObjectWithTag("line6");
        seven = GameObject.FindGameObjectWithTag("line7");
        eight = GameObject.FindGameObjectWithTag("line8");
        nine = GameObject.FindGameObjectWithTag("line9");
        ten = GameObject.FindGameObjectWithTag("line10");

        //자식 오브젝트 배열 안에 넣기
        for (int i = 0; i < 10; i++)
        {
            array1[i] = one.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 10; i++)
        {
            array2[i] = two.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 10; i++)
        {
            array3[i] = three.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 10; i++)
        {
            array4[i] = four.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 10; i++)
        {
            array5[i] = five.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 10; i++)
        {
            array6[i] = six.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 10; i++)
        {
            array7[i] = seven.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 10; i++)
        {
            array8[i] = eight.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 10; i++)
        {
            array9[i] = nine.transform.GetChild(i).gameObject; ;
        }
        for (int i = 0; i < 10; i++)
        {
            array10[i] = ten.transform.GetChild(i).gameObject;
        }

        Tmp(array11, 0);
        Tmp(array12, 1);
        Tmp(array13, 2);
        Tmp(array14, 3);
        Tmp(array15, 4);
        Tmp(array16, 5);
        Tmp(array17, 6);
        Tmp(array18, 7);
        Tmp(array19, 8);
        Tmp(array20, 9);
        

    }


    // Update is called once per frame
    void Update()
    {
        //자동완성 함수 돌리기
        AutoFun(array1);
        AutoFun(array2);
        AutoFun(array3);
        AutoFun(array4);
        AutoFun(array5);
        AutoFun(array6);
        AutoFun(array7);
        AutoFun(array8);
        AutoFun(array9);
        AutoFun(array10);
        AutoFun(array11);
        AutoFun(array12);
        AutoFun(array13);
        AutoFun(array14);
        AutoFun(array15);
        AutoFun(array16);
        AutoFun(array17);
        AutoFun(array18);
        AutoFun(array19);
        AutoFun(array20);
    }


    public void Tmp(GameObject[] array,int i) //세로에 있는 자식 오브젝트 배열에 넣기
    {
        array[0] = one.transform.GetChild(i).gameObject;
        array[1] = two.transform.GetChild(i).gameObject;
        array[2] = three.transform.GetChild(i).gameObject;
        array[3] = four.transform.GetChild(i).gameObject;
        array[4] = five.transform.GetChild(i).gameObject;
        array[5] = six.transform.GetChild(i).gameObject;
        array[6] = seven.transform.GetChild(i).gameObject;
        array[7] = eight.transform.GetChild(i).gameObject;
        array[8] = nine.transform.GetChild(i).gameObject;
        array[9] = ten.transform.GetChild(i).gameObject;
    }
    public void AutoFun(GameObject[] a) //자동완성 함수
    {
        //배열안에 square2(맞춰야 하는 그림)이 남았는지 확인
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i].tag != "square2")
            {
                finish = 1; //맞춰야 하는 그림이 더이상 없음
            }
            else
            {
                finish = 0; //아직 맞춰야 할 그림이 남음
                break;
            }

        }

        if (finish == 1) //맞춰야 하는 그림이 더이상 없을 때
        {
            for (int i = 0; i < a.Length; i++)
            {
                //정답이 아닌 그림 엑스 표시하기
                if (a[i].tag=="square") 
                {
                    if (tmp.GetComponent<BtnActive>().BtnO == 1)
                    {
                        //임시로 버튼 0으로 만들고 다시 1로 돌아가기
                        tmp.GetComponent<BtnActive>().BtnO = 0;
                        a[i].GetComponent<ImageChange2>().ChangeImageX();
                        tmp.GetComponent<BtnActive>().BtnO = 1;
                    }
                    else
                    {
                        a[i].GetComponent<ImageChange2>().ChangeImageX();
                    }

                }

            }

        }
    }
}
