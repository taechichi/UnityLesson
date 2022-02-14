using System;

namespace _220214_REVIEW_13_UnityLesson_CSharp_WhileLoop
{
    class Program
    {
        // while 의 구조
        /*
         * while(조건)
         * {
         *      조건이 참일 때 반복할 내용
         * }
         */

        // 무한루프(while 의 조건이 항상 참일경우)
        // 절대 코드에 있어서 안되는 존대
        /*
         * while(true)
         * {
         *  
         * }
         */
        static void Main(string[] args)
        {
            string[] arr_PersonName = new string[3];
            arr_PersonName[0] = "김아무개";
            arr_PersonName[1] = "이아무개";
            arr_PersonName[2] = "박아무개";

            int length = arr_PersonName.Length;
            int count = 0;
            // 조건문 안에, 내지 코딩문자에 직접적으로 임의의 숫자를 입력하는 것은 좋지 못하다
            // ex) while( count < 3 ) <- 이것은 좋지 못하다.
            // -> 매직넘버 이슈 (나중에 수정하기도 어려울뿐더러 또, 임의의 숫자가 뭘 의미하는지도 모름;)
            while(count < length)
            {
                Console.WriteLine(arr_PersonName[count]);
                count++;
            }

            count = 0;
            while(true)
            {
                if(count < length)
                {
                    Console.WriteLine(arr_PersonName[count]);
                }
                else
                {
                    break;
                }

                count++;
            }
        }
    }
}
