using System;

namespace _220208_REVIEW_05_UnityLesson_CSharp_Method
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // argument (x), return (o)
        static void PrintHelloWorld()
        {
            Console.WriteLine("HelloWorld!");
        }
        // argument (o), return (x)
        static void PrintSomething(string something)    // 함수 정의에서 소괄호 안 내용은 인자(Argument)
        {
            Console.WriteLine(something);
        }

        // argument (o), return (o)
        // something 을 콘솔창에 출력하고 true를 반환하는 함수
        static bool PrintSomethingAndReturnIsFinished(string something)
        {
            bool isFinished = false;    // 함수 내에서 정의된 변수를 지역변수라고 한다.
                                        // 지역 변수는 다른 함수에서 가져다 쓸 수 없다.
                                        // 해당 함수 내에서 '만' 연산을 처리하기 위해 사용.
            Console.WriteLine(something);

            if(something == "HelloWorld")
            {
                isFinished = true;
            }
            else
            {
                isFinished = false;
            }


            return isFinished;
        }

        /*
         * 반환형 함수이름(인자(argument) 자료형 인자이름, 인자자료형 인자이름 ....)
         * {
         *      함수 연산 내용
         *      
         *      return 반환할 내용
         * }
         */
    }
}
