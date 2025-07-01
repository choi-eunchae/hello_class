using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello, World!");


        string characterName = "라라";
        char bloodType = 'A';
        int age = 17;
        float height = 168.3f;
        bool isFemale = true;
        var country = "영국";

        Debug.Log("캐릭터 이름 : " + characterName);
        Debug.Log("혈액형 : " + bloodType);
        Debug.Log("나이 : " + age);
        Debug.Log("키 : " + height);
        Debug.Log("여성인가? : " + isFemale);
        Debug.Log("출신 국가 : " + country);

        float distance = GetDistance(2, 2, 5, 6);
        Debug.Log("(2,2)에서 (5,6)까지의 거리 : " + distance);



        int love = 80;

        if (love >= 90)
        {
            Debug.Log("트루엔딩: 히로인과 결혼했다!");
        }
        else if (love >= 70)
        {
            Debug.Log("굿엔딩: 히로인과 사귀게 되었다!");
        }
        else
        {
            Debug.Log("배드엔딩: 히로인에게 차였다..");
        }

        age = 11;

        if (age > 7 && age < 18)
        {
            Debug.Log("의무교육을 받고 있습니다.");
        }
        if (age < 13 || age > 70)
        {
            Debug.Log("일을 할 수 없는 나이입니다.");
        }

        //for 반복하기
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i + "번째 순번입니다.");
        }

        //while 반복하기
        bool isDead = false;
        int hp = 100;

        while (!isDead)
        {
            Debug.Log("현재 체력: " + hp);

            hp -= 33;

            if (hp <= 0)
            {
                isDead = true;
                Debug.Log("플레이어는 죽었습니다.");
            }
        }
        
        //배열로 학생 점수 관리하기
        int[] students = new int[5];

        students[0] = 100;
        students[1] = 90;
        students[2] = 80;
        students[3] = 70;
        students[4] = 60;

        Debug.Log("배열의 길이는? " + students.Length);
        
        for (int i = 0; i < students.Length; i++)
        {
            Debug.Log(i + "번째 학생의 점수: " + students[i]);
        }

    }
    float GetDistance(float x1, float y1, float x2, float y2){
        float width = x2 - x1;
        float height = y2 - y1;

        float distance = width * width + height * height;
        distance = Mathf.Sqrt(distance);

        return distance;
    }
}

