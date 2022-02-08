using System;

namespace _220208_REVIEW_UnityLesson_CSharp_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHelloWorld();
            PrintSomething("TaeChichi Neople gazua!"); // 함수 호출에서 소괄호 안 내용은 매개변수(parameter)라고 함
            bool tmpIsFinished = false;
            tmpIsFinished = PrintSomethingAndReturnIsFinished("TaeChichi");
            Console.WriteLine(tmpIsFinished);
        }

        // parameter(x), return(x)
        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        // parameter(o), return(x)
        static void PrintSomething(string something)    // 함수 정의에서 소괄호 안 내용은 인자 (Argument)
        {
            Console.WriteLine(something);
        }

        // parameter(o), return(o)
        static bool PrintSomethingAndReturnIsFinished(string something)
        {
            bool isFinished = false;    // Local variable ( 이 함수에서만 연산을 위해 사용)
            isFinished = true;
            return isFinished;
        }

        /*반환형 함수이름(인자자료형 인자이름, 인자자료형 인자이름...)
         * {
         *      함수 연산 내용
         *      
         *      return 반환할 내용
         * }
         */
    }
}
