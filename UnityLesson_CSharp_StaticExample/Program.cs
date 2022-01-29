using System;

namespace UnityLesson_CSharp_StaticExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // orc 생성자로 orc1, orc2 인스턴스 생성
            Orc orc1 = new Orc();
            Orc orc2 = new Orc();

            // static 접근..?
            Orc.typeName = "ORC_TYPE";
            Orc.SayTypeName();

            // orc1 변수 초기화
            orc1.age = 16;
            orc1.height = 180.3f;
            orc1.isResting = false;
            orc1.genderChar = 'M';
            orc1.name = "James";

            // orc1 함수 호출
            orc1.Jump();
            orc1.Smash();

            // 한줄띄기
            Console.WriteLine();

            orc1.SayAllInfo();


            // orc2 변수 초기화
            orc2.age = 18;
            orc2.height = 193.2f;
            orc2.isResting = false;
            orc2.genderChar = 'F';
            orc2.name = "Viangka";

            // orc2 함수 호출
            orc2.Jump();
            orc2.Smash();

            Console.WriteLine();

            orc2.SayAllInfo();

        }
    }


    public class Orc
    {
        static public string typeName;
        public int age;
        public float height;
        public bool isResting;
        public char genderChar;
        public string name;

        static public void SayTypeName()
        {
            Console.WriteLine(typeName);
        }

        public void Jump()
        {
            Console.WriteLine($"{name} (이)가 점프했다.");
        }

        public void Smash()
        {
            Console.WriteLine($"{name} (이)가 휘둘렀다.");
        }

        public void SayAllInfo()
        {
            SayName();
            SayAge();
            SayHeight();
            SayIsResting();
            SayGenderChar();
            Console.WriteLine();
        }


        void SayAge()
        {
            Console.WriteLine($"{name}의 나이 : {age}");
        }

        void SayHeight()
        {
            Console.WriteLine($"{name}의  키 : {height}");
        }

        void SayIsResting()
        {
            Console.WriteLine($"{name}은 쉬고있나? : {isResting}");
        }

        void SayGenderChar()
        {
            Console.WriteLine($"{name}의 성별 : {age}");
        }

        void SayName()
        {
            Console.WriteLine(name);
        }

    }

    static public class Person
    {
    }
}
