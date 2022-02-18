using System;
// structure (구조체)
// 멤버변수들을 가지는 타입
namespace _220218_REVIEW_18_UnityLesson_CSharp_Structure
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            warrior.stats._STR = 10;
            warrior.stats._DEX = 10;
            warrior.stats._CON = 10;
            warrior.stats._WIS = 10;
            warrior.stats._INT = 10;
            warrior.stats._REG = 10;

            Warrior[] arr_Warrior = new Warrior[10];
            int arr_Warrior_Length = arr_Warrior.Length;


            // 멤버변수 stats 의 멤버 변수를 for 문에서 초기화하는 방법
            for (int count = 0; count < arr_Warrior_Length; count++)
            {
                arr_Warrior[count] = new Warrior();
                arr_Warrior[count].stats._STR = 10;
                arr_Warrior[count].stats._DEX = 10;
                arr_Warrior[count].stats._CON = 10;
                arr_Warrior[count].stats._WIS = 10;
                arr_Warrior[count].stats._INT = 10;
                arr_Warrior[count].stats._REG = 10;
            }

            // 지역변수 stats 를 초기화한 후 for 문에서 멤버변수 stats 를 초기화하는 방법
            Stats tmpStats = new Stats();
            tmpStats._STR = 10;
            tmpStats._DEX = 20;
            tmpStats._CON = 30;
            tmpStats._WIS = 40;
            tmpStats._INT = 50;
            tmpStats._REG = 60;

            for (int count = 0; count < arr_Warrior_Length; count++)
            {
                arr_Warrior[count].stats = tmpStats;
            }

            // 멤버변수 stats 를 초기화하는 멤버함수 SetStats을 호출하는 방법
            for (int count = 0; count < arr_Warrior_Length; count++)
            {
                arr_Warrior[count].SetStats(10, 20, 30, 40, 50, 60);
            }
        }
    }
}
