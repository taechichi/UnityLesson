using System;

namespace _220219_5week_02_UnityLesson_CSharp_Delegate
{
    internal class Program
    {
        // 이런식으로 쓴다
        // delegate void aa(int a, int b);


        delegate int CalDelegate(int a, int b);
        static bool doSum = false;
        static bool doSub = false;
        static bool doDiv = true;

        static void Main(string[] args)
        {
            int a = 4;
            int b = 7;


            // int sumResult = Sum(a, b);
            // int subResult = Sub(a, b);


            CalDelegate CD_Sum = Sum;
            CalDelegate CD_Sub = Sub;

            // 람다식 : 함수를 정의하지 않고 연산에 필요한 내용만 표현하는 방법
            CalDelegate CD_Div = delegate (int a, int b)
            {
                return a / b;
            };


            if(doSum)
            {
                PrintCalResult(a, b, CD_Sum);
            }
            
            if(doSub)
            {
                PrintCalResult(a, b, CD_Sub);
            }

            if(doDiv)
            {
                PrintCalResult(a, b, CD_Div);
            }



            
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Sub(int a, int b)
        {
            return a - b;
        }

        static void PrintCalResult(int a, int b, CalDelegate calMethod)
        {
            Console.WriteLine($"CalResult : {calMethod(a, b)}");
        }

        // 근데... 의미가 있나? 어떤때 어떻게 쓰지..?
        // 경우에 따라서 다른 연산을 하고 싶을때 하는거죠..(?)
        // 조건에 따라서 다른 함수를 호출하는것이다!! 나중에는 꼭 유용하게 쓰일 것입니다.

        // 보통 쓰는 이유 : 다른 클래스에 나만의 특정한 요구를 하고 싶을때 쓰기도함.
        // 빨리 플젝하고 싶네 허허
    }
}
