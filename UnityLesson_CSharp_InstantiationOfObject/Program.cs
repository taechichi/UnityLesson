using System;

namespace UnityLesson_CSharp_InstantiationOfObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            // 점(.) 연산자 - 멤버에 접근하는 연산자
            person1.age = 28;
            person1.height = 174.2f;
            person1.isResting = true;
            person1.genderChar = 'M';
            person1.name = "TaeSeungHwan";

            // 객체의 멤버 함수 호출
            person1.SayAllInfo();
            
            Person person2 = new Person();

            person2.age = 31;
            person2.height = 164.3f;
            person2.isResting = false;
            person2.genderChar = 'F';
            person2.name = "YoonSoJeong";

            person2.SayAllInfo();
        }
    }

    public class Person
    {
        public int age;
        public float height;
        public bool isResting;
        public char genderChar;
        public string name;

        public void SayAllInfo()
        {
            SayAge();
            SayHeight();
            SayIsResting();
            SayGenderChar();
            SayName();
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
}
