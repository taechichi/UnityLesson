﻿using System;

namespace _220208_REVIEW_04_UnityLesson_CSharp_If
{
    class Program
    {
        static bool condition1 = true;
        static bool condition2 = true;
        static bool condition3;

        static void Main(string[] args)
        {
            if(condition1)
            {
                // 조건 1이 참일 때 실행할 내용
                Console.WriteLine("조건 1이 참이다");
            }
            else if(condition2)
            {
                // 조건 1이 거짓이고 조건 2가 참일 때 실행할 내용
                Console.WriteLine("조건 1이 거짓이고, 조건 2가 참이다");
            }
            else if(condition3)
            {
                // 조건 1, 2 다 거짓이고 조건 3이 참일 때 실행할 내용
                Console.WriteLine("조건 1,2가 거짓이고 조건 3이 참이다.");
            }
            else
            {
                // else 위의 모든 조건이 거짓일 때 실행할 내용
                Console.WriteLine("조건 1, 2, 3 모두 거짓이다.");
            }
        }

    }
}
