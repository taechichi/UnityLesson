using System;

namespace _220205_UnityLesson_CSharp_Array
{
    internal class Program
    {
        // array
        // 형태 : 자료형[](배열형태)
        // 자료형이 **'정적'**으로나열되어있는 형태
        
        // 크기를 한번 정해놓으면 바꿀수 없다.
        //     int[]  <배열이름> = new int[할당크기]
        static int[] arr_TestInt = new int[5];
        static float[] arr_TestFloat = new float[3];
        static float[] arr_TestFloat2 = { 1.0f, 2.0f, 3.0f, 4.0f };
        static string[] arr_TestString = new string[3];


        static void Main(string[] args)
        {
            // int
            arr_TestInt[0] = 5; // arr_TestInt[0] 자체는 int 형이다. 그렇다면 범위도?
            arr_TestInt[1] = 4;
            arr_TestInt[2] = 3;
            arr_TestInt[3] = 2;
            arr_TestInt[4] = 1;

            Console.WriteLine(arr_TestInt); // type만 출력 이게모지????
            Console.WriteLine(arr_TestInt[0]);
            Console.WriteLine(arr_TestInt[1]);
            Console.WriteLine(arr_TestInt[2]);
            Console.WriteLine(arr_TestInt[3]);
            Console.WriteLine(arr_TestInt[4]);

            // float
            arr_TestFloat[0] = 2.0f;
            arr_TestFloat[1] = 3.0f;
            arr_TestFloat[2] = (float)4;

            Console.WriteLine(arr_TestFloat[0]);
            Console.WriteLine(arr_TestFloat[1]);
            Console.WriteLine(arr_TestFloat[2]);

            // string
            arr_TestString[0] = "Tae";
            arr_TestString[1] = (string)"Seung";
            arr_TestString[2] = (string)"Hwan";

            Console.WriteLine(arr_TestString[0]);
            Console.WriteLine(arr_TestString[1]);
            Console.WriteLine(arr_TestString[2]);

            
        }
    }
}
