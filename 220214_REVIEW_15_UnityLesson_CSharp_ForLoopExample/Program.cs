using System;

// Orc 객체를 10마리 만들고
// Orc 들의 인스턴스는 Orc 타입 배열에 넣어준다.
// 각 오크의 이름은 "오크0", "오크1", "오크2", ... , "오크9"
// 각 오크에게 isResting 멤버변수값은 랜덤으로 (노가다로) 넣어준다.
// 각 오크가 쉬고있는지 확인해서 쉬고있다면 점프하도록 한다.

namespace _220214_REVIEW_15_UnityLesson_CSharp_ForLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc[] arr_Orc = new Orc[10];


        }
    }

    public class Orc
    {
        public string name;
        public float height;
        public float weight;
        public int age;
        public char genderChar;
        public bool isResting;

        public void Smash()
        {
            Console.WriteLine($"{name} (이)가 휘둘렀다.");
        }

        public void Jump()
        {
            Console.WriteLine($"{name} (이)가 점프했다.");
        }
    }
}
