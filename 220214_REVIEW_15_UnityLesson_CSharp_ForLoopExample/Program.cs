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

            int count = 0;
            int arr_Orc_length = arr_Orc.Length;
            for (count = 0; count < arr_Orc_length; count++)
            {
                arr_Orc[count] = new Orc();
                arr_Orc[count].name = $"오크{count}";
            }

            arr_Orc[0].isResting = true;
            arr_Orc[1].isResting = false;
            arr_Orc[2].isResting = true;
            arr_Orc[3].isResting = true;
            arr_Orc[4].isResting = false;
            arr_Orc[5].isResting = true;
            arr_Orc[6].isResting = true;
            arr_Orc[7].isResting = true;
            arr_Orc[8].isResting = false;
            arr_Orc[9].isResting = true;

            for (count = 0; count < arr_Orc_length; count++)
            {
                if(arr_Orc[count].isResting)
                {
                    arr_Orc[count].Jump();
                }
                else
                {
                    Console.WriteLine($"{arr_Orc[count].name} 은(는) 바쁘다.");
                }
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
            Console.WriteLine($"{name} (이)가 휘둘렀다.");
        }

        public void Jump()
        {
            Console.WriteLine($"{name} (이)가 점프했다.");
        }
    }
}
