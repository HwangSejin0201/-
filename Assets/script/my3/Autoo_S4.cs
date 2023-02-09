using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autoo_S4 : MonoBehaviour
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
    public GameObject eleven;
    public GameObject twelve;
    public GameObject thirteen;
    public GameObject fourteen;
    public GameObject fifteen;
    public GameObject sixteen;
    public GameObject seventeen;
    public GameObject eighteen;
    public GameObject nineteen;
    public GameObject twenty;
    public GameObject tmp;

    public GameObject[] array1 = new GameObject[20];
    public GameObject[] array2 = new GameObject[20];
    public GameObject[] array3 = new GameObject[20];
    public GameObject[] array4 = new GameObject[20];
    public GameObject[] array5 = new GameObject[20];
    public GameObject[] array6 = new GameObject[20];
    public GameObject[] array7 = new GameObject[20];
    public GameObject[] array8 = new GameObject[20];
    public GameObject[] array9 = new GameObject[20];
    public GameObject[] array10 = new GameObject[20];
    public GameObject[] array11 = new GameObject[20];
    public GameObject[] array12 = new GameObject[20];
    public GameObject[] array13 = new GameObject[20];
    public GameObject[] array14 = new GameObject[20];
    public GameObject[] array15 = new GameObject[20];
    public GameObject[] array16 = new GameObject[20];
    public GameObject[] array17 = new GameObject[20];
    public GameObject[] array18 = new GameObject[20];
    public GameObject[] array19 = new GameObject[20];
    public GameObject[] array20 = new GameObject[20];
    public GameObject[] array21 = new GameObject[20];
    public GameObject[] array22 = new GameObject[20];
    public GameObject[] array23 = new GameObject[20];
    public GameObject[] array24 = new GameObject[20];
    public GameObject[] array25 = new GameObject[20];
    public GameObject[] array26 = new GameObject[20];
    public GameObject[] array27 = new GameObject[20];
    public GameObject[] array28 = new GameObject[20];
    public GameObject[] array29 = new GameObject[20];
    public GameObject[] array30 = new GameObject[20];
    public GameObject[] array31 = new GameObject[20];
    public GameObject[] array32 = new GameObject[20];
    public GameObject[] array33 = new GameObject[20];
    public GameObject[] array34 = new GameObject[20];
    public GameObject[] array35 = new GameObject[20];
    public GameObject[] array36 = new GameObject[20];
    public GameObject[] array37 = new GameObject[20];
    public GameObject[] array38 = new GameObject[20];
    public GameObject[] array39 = new GameObject[20];
    public GameObject[] array40 = new GameObject[20];



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
        eleven = GameObject.FindGameObjectWithTag("line11");
        twelve = GameObject.FindGameObjectWithTag("line12");
        thirteen = GameObject.FindGameObjectWithTag("line13");
        fourteen = GameObject.FindGameObjectWithTag("line14");
        fifteen = GameObject.FindGameObjectWithTag("line15");
        sixteen = GameObject.FindGameObjectWithTag("line16");
        seventeen = GameObject.FindGameObjectWithTag("line17");
        eighteen = GameObject.FindGameObjectWithTag("line18");
        nineteen = GameObject.FindGameObjectWithTag("line19");
        twenty = GameObject.FindGameObjectWithTag("line20");

        //자식 오브젝트 배열 안에 넣기
        for (int i = 0; i < 20; i++)
        {
            array1[i] = one.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 20; i++)
        {
            array2[i] = two.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 20; i++)
        {
            array3[i] = three.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 20; i++)
        {
            array4[i] = four.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 20; i++)
        {
            array5[i] = five.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 20; i++)
        {
            array6[i] = six.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 20; i++)
        {
            array7[i] = seven.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 20; i++)
        {
            array8[i] = eight.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 20; i++)
        {
            array9[i] = nine.transform.GetChild(i).gameObject; ;
        }
        for (int i = 0; i < 20; i++)
        {
            array10[i] = ten.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 20; i++)
        {
            array11[i] = eleven.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 20; i++)
        {
            array12[i] = twelve.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 20; i++)
        {
            array13[i] = thirteen.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 20; i++)
        {
            array14[i] = fourteen.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 20; i++)
        {
            array15[i] = fifteen.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 20; i++)
        {
            array16[i] = sixteen.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 20; i++)
        {
            array17[i] = seventeen.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 20; i++)
        {
            array18[i] = eighteen.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 20; i++)
        {
            array19[i] = nineteen.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 20; i++)
        {
            array20[i] = twenty.transform.GetChild(i).gameObject;
        }
        


        
        Tmp(array21, 0);
        Tmp(array22, 1);
        Tmp(array23, 2);
        Tmp(array24, 3);
        Tmp(array25, 4);
        Tmp(array26, 5);
        Tmp(array27, 6);
        Tmp(array28, 7);
        Tmp(array29, 8);
        Tmp(array30, 9);
        Tmp(array31, 10);
        Tmp(array32, 11);
        Tmp(array33, 12);
        Tmp(array34, 13);
        Tmp(array35, 14);
        Tmp(array36, 15);
        Tmp(array37, 16);
        Tmp(array38, 17);
        Tmp(array39, 18);
        Tmp(array40, 19);


    }


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
        AutoFun(array21);
        AutoFun(array22);
        AutoFun(array23);
        AutoFun(array24);
        AutoFun(array25);
        AutoFun(array26);
        AutoFun(array27);
        AutoFun(array28);
        AutoFun(array29);
        AutoFun(array30);
        AutoFun(array31);
        AutoFun(array32);
        AutoFun(array33);
        AutoFun(array34);
        AutoFun(array35);
        AutoFun(array36);
        AutoFun(array37);
        AutoFun(array38);
        AutoFun(array39);
        AutoFun(array40);
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
        array[10] = eleven.transform.GetChild(i).gameObject;
        array[11] = twelve.transform.GetChild(i).gameObject;
        array[12] = thirteen.transform.GetChild(i).gameObject;
        array[13] = fourteen.transform.GetChild(i).gameObject;
        array[14] = fifteen.transform.GetChild(i).gameObject;
        array[15] = sixteen.transform.GetChild(i).gameObject;
        array[16] = seventeen.transform.GetChild(i).gameObject;
        array[17] = eighteen.transform.GetChild(i).gameObject;
        array[18] = nineteen.transform.GetChild(i).gameObject;
        array[19] = twenty.transform.GetChild(i).gameObject;
  
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
                if (a[i].CompareTag("square")) 
                {

                    if (tmp.GetComponent<BtnActive>().BtnO == 1)
                    {
                        //임시로 버튼 0으로 만들고 다시 1로 돌아가기
                        tmp.GetComponent<BtnActive>().BtnO = 0;
                        a[i].GetComponent<ImageChange2_S4>().ChangeImageX();
                        tmp.GetComponent<BtnActive>().BtnO = 1;
                    }
                    else
                    {
                        a[i].GetComponent<ImageChange2_S4>().ChangeImageX();
                    }

                }

            }

        }
    }
}
