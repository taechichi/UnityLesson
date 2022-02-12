using System;

namespace _220205_UnityLesson_CSharp_WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            while (조건)
            {
              조건이 참일 때 반복할 내용  
            }
            
            // 이런 형식은 무한 루프 (while의 조건이 항상 참일 경우)
            // 절대 코드에 있어서는 안되는 존재
            // 개발자들은 잘 안씀 무한루프 생길 여지가 있기 때문에;
            while (true)
            {

            }
            */

            string[] arr_PersonName = new string[3];
            arr_PersonName[0] = "TaeSeungHwan";
            arr_PersonName[1] = "YoonSoJeong";
            arr_PersonName[2] = "Chocho";

            int ar_PersonName_len = arr_PersonName.Length;
            // Console.WriteLine(arr_PersonName[0]); ... 줄줄 쓰는것이 아니라
            int c_i = 0;
            // 조건문안에, 내지 코딩문자에 직접 임의의 숫자를 쓰는것은 좋지 못하다!
            // -> 매직넘버 이슈 이런식으로 해야 좋다.
            while (c_i < ar_PersonName_len)
            {               
                Console.WriteLine(arr_PersonName[c_i]);
                c_i++;
            }

            // 좋지 못한 방법
            c_i = 0;
            while (true)
            {
                if(c_i < ar_PersonName_len)
                {
                    Console.WriteLine(arr_PersonName[c_i]);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
