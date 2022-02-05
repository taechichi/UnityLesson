using System;

namespace _220205_UnityLesson_CSharp_ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr_PersonName = new string[6];
            arr_PersonName[0] = "TaeSeungHwan";
            arr_PersonName[1] = "YoonSoJeong";
            arr_PersonName[2] = "Chocho";
            arr_PersonName[3] = "TaeSeungHwan";
            arr_PersonName[4] = "YoonSoJeong";
            arr_PersonName[5] = "Chocho";

            int ar_PersonName_length = arr_PersonName.Length;

            for (int c_i = 0; c_i < ar_PersonName_length; c_i++)
            {
                Console.WriteLine(arr_PersonName[c_i]);
                Console.WriteLine($"*");
            }

            /*
            for (인덱스용 변수 선원 및 초기화; for문을 실행할 조건; 인덱스++_루프가 한번 실행될때마다 마지막에 실행할 문장)
            {
                반복 수행 시 실행할 내용
            }
            */

            // "TaeSeungHwan"만 출력하고 싶다. "TaeSeungHwan"의 규칙 3n;
            // 모든 배열 요소를 검색하는 예시
            for(int c_i=0; c_i < ar_PersonName_length; c_i++)
            {
                if(arr_PersonName[c_i] == "TaeSeungHwan")
                {
                    Console.WriteLine(arr_PersonName[c_i]);
                }
            }

            Console.WriteLine($"==================");
            // 인덱스 규칙을 활용한 예시
            for (int c_i = 0; c_i < ar_PersonName_length; c_i+=3)
            {
                Console.WriteLine(arr_PersonName[c_i]);
            }
        }
    }
}
