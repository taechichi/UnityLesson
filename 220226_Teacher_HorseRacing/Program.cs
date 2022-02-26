using System;
using System.Threading;

namespace _220226_Teacher_HorseRacing
{
    internal class Program
    {
        // [1]
        static Random random = new Random();   // 말의 달리는 속도를 랜덤하게 생성
        static bool isGameFinished = false;
        static int minSpeed = 10;
        static int maxSpeed = 20;
        static int finishDistance = 200;

        static void Main(string[] args)
        {
            Horse[] arr_horse = new Horse[5];               // 말 5다리 배열
            string[] arr_FinishedHorseName = new string[5]; // 결승점 통과한 말들의 이름
            int currentGrade = 1;   // 현재등수

            // 말 생성 및 초기화
            int length = arr_horse.Length;
            for (int i = 0; i < length; i++)
            {
                arr_horse[i] = new Horse();             // 말 인스턴스화
                arr_horse[i].name = $"경주마{i + 1}";   // 말의 이름 초기화
            }
            // [7]
            Console.WriteLine("시작하려면 엔터를 누르세요!");
            Console.ReadLine();

            Console.WriteLine("경주 시작!");
            int count = 0;
            while (isGameFinished == false) // 게임이 끝날때까지 돌아가는 반복문
            {
                Thread.Sleep(1000); // 1초 지연
                count++;
                Console.WriteLine($"========================= {count} ========================= ");

                // 랜덤한 속도로 말을 달리는 반복문
                for (int i = 0; i < length; i++)
                {
                    // [5]
                    if( arr_horse[i].available )
                    {
                        random = new Random();  // 새로운 난수 인스턴스화
                        int tmpMoveDistance = random.Next(minSpeed, maxSpeed + 1);
                        arr_horse[i].Run(tmpMoveDistance);  // i 번째 말을 10~20 사이 거리만큼 움직임.
                        Console.WriteLine($"{arr_horse[i].name} 가 달린거리 : {arr_horse[i].distance}");

                        // 결승점 도착 체크
                        if (arr_horse[i].distance >= finishDistance)
                        {
                            arr_FinishedHorseName[currentGrade - 1] = arr_horse[i].name;
                            // [4]
                            arr_horse[i].available = false;
                            currentGrade++;
                        }
                    }

                    // [6]                   
                }
                Console.WriteLine("=========================");
                // 경주 끝났즌지 체크( 모든 말이 들어왔는지)
                if(currentGrade > length)
                {
                    isGameFinished = true;
                    Console.WriteLine("경주 끝!");
                    break;
                }

            } // whileLoop

            Console.WriteLine("========================= 결과 발표 =========================");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{i + 1} 등 : {arr_FinishedHorseName[i]}");
            }
            // [8]
            Console.WriteLine("종료하려면 엔터를 누르세요...");
            Console.ReadLine();
        }
    }
}
