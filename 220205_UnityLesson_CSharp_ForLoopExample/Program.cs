using System;

// Orc 객체를 10마리 만들고
// Orc 들의 인스턴스는 Orc타입 배열에 넣어준다.
// 각 오크의 이름은 "오크0", "오크1", ..., "오크9"
// 각 오크에게 isResting 멤버변수값은 랜덤으로 넣어준다.
// 각 오크가 쉬고있는지 확인해서 쉬고있다면 점프하도록 한다.
namespace _220205_UnityLesson_CSharp_ForLoopExample
{
    internal class Program
    {

        static Orc[] arr_Orc = new Orc[10];
        static void Main(string[] args)
        {
            int arr_orc_length = arr_Orc.Length;
            for(int c_i=0; c_i < arr_orc_length; c_i++)
            {
                arr_Orc[c_i] = new Orc();
                arr_Orc[c_i].name = $"Orc{c_i+1}";
            }

            // isResting 랜덤 세팅
            for (int c_i = 0; c_i < arr_orc_length; c_i++)
            {
                arr_Orc[c_i].isResting = GetRandomBool();
            }
            

            for (int c_i = 0; c_i < arr_orc_length; c_i++)
            {
                if(arr_Orc[c_i].isResting)
                {
                    arr_Orc[c_i].Jump();
                }
                else
                {
                    //nothing
                }
            }
        }

        static private bool GetRandomBool()
        {
            Random random = new Random();

            int randomInt = random.Next(0, 2); // minValue ~ maxValue-1, (0, 2) 범위중 난수를 생성함. // 드랍확률 이런식으로 만듬
            bool randomBool = Convert.ToBoolean(randomInt);
            return randomBool;
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
