using System;

namespace UnityLesson_CSharp_InstantiationExmaple1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Orc orc1 = new Orc();
            Orc orc2 = new Orc();

            // orc1 초기화
            orc1.name = "상급오크";
            orc1.height = 240.2f;
            orc1.weight = 200.0f;
            orc1.age = 140;
            orc1.genderChar = 'M';
            orc1.isResting = false;

            // orc2 초기화
            orc2.name = "하급오크";
            orc2.height = 140.4f;
            orc2.weight = 120.0f;
            orc2.age = 60;
            orc2.genderChar = 'F';
            orc2.isResting = true;

            // main
            // orc1
            if(orc1.isResting) // orc1.isResting == true 와는 다르다.
            {
                orc1.Jump();
                orc1.Smash();
            }
            else
            {
                Console.WriteLine($"{orc1.name} (이)가 바쁘다...");
            }

            // orc2
            if(orc2.isResting)
            {
                orc2.Jump();
                orc2.Smash();
            }
            else
            {
                Console.WriteLine($"{orc2.name} (이)가 바쁘다...");
            }

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
            Console.WriteLine($"{name} (이)가 무기를 휘둘렀다!");
        }

        public void Jump()
        {
            Console.WriteLine($"{name} (이)가 점프를 시전했다!");
        }


    }
}