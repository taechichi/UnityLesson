using System;
// structure (구조체)
// 멤버 변수들을 가지는 타입(Type)


// 클래스는 사실 따로 script를 갖는다.
namespace _220212_02_UnityLesson_CSharp_Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            /*
            warrior._STR = 10;
            warrior._DEX = 10;
            warrior._CON = 10;
            warrior._WIS = 10;
            warrior._INT = 10;
            warrior._REG = 10;
            */

            warrior.stats._STR = 10;
            warrior.stats._DEX = 10;
            warrior.stats._CON = 10;
            warrior.stats._WIS = 10;
            warrior.stats._INT = 10;
            warrior.stats._REG = 10;

            Priest priest = new Priest();
            /*
            priest._STR = 10;
            priest._DEX = 10;
            priest._CON = 10;
            priest._WIS = 10;
            priest._INT = 10;
            priest._REG = 10;
            */

            priest.stats._STR = 10;
            priest.stats._DEX = 10;
            priest.stats._CON = 10;
            priest.stats._WIS = 10;
            priest.stats._INT = 10;
            priest.stats._REG = 10;



            // 10개 워리어 만들기
            Warrior[] arr_Warrior = new Warrior[10];

            int length = arr_Warrior.Length;
            int count = 0;

            // 멤버 변수 stats 의 멤버 변수를 for 문에서 초기화 하는 방법
            for(count = 0; count < length; count++)
            {
                arr_Warrior[count] = new Warrior();
                arr_Warrior[count].stats._STR = 10;
                arr_Warrior[count].stats._DEX = 10;
                arr_Warrior[count].stats._CON = 10;
                arr_Warrior[count].stats._WIS = 10;
                arr_Warrior[count].stats._INT = 10;
                arr_Warrior[count].stats._REG = 10;
            }

            // 지역변수 stats 을 초기화한 후 for 문에서 멤버변수 stats을 초기화하는 방법
            Stats tmpStats = new Stats();
            tmpStats._STR = 10;
            tmpStats._DEX = 10;
            tmpStats._CON = 10;
            tmpStats._WIS = 10;
            tmpStats._INT = 10;
            tmpStats._REG = 10;

            for(count=0; count < length; count++)
            {
                arr_Warrior[count].stats = tmpStats;
            }


            // 멤버변수 stats 을 초기화하는 멤버함수 SetStats을 호출하는 방법 (편-안)
            for(count=0; count < length; count++)
            {
                arr_Warrior[count].SetStats(10, 20, 30, 40, 50, 60);
            }
        }
    }
}
