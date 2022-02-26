using System;
using System.Collections.Generic;


namespace _220226_TEACHER_DiceGame
{
    internal class Program
    {
        // [1]
        // TileMap, TileInfo, TileInfo_Star 생성

        // [8]
        // static 초기 데이터가 필요한 애들
        static private int totalTile = 20;          // 총 칸 갯수
        static private int totalDiceNumber = 20;    // 총 주사위 갯수
        static private Random random;
        
        static void Main(string[] args)
        {
            int previousTileIndex = 0;              // 이전 칸의 인덱스
            int currentTileIndex = 0;               // 현재 칸의 인덱스
            int currentStarPoint = 0;               // 샛별 점수


            // 맵 생성
            TileMap map = new TileMap();
            map.MapSetup(totalTile);

            int currentDiceNum = totalDiceNumber;
            // 주사위 게임 시작
            while (currentDiceNum > 0)
            {
                int diceValue = RollADice();        // 주사위 굴리기
                currentDiceNum--;                   // 주사위 횟수 차감
                currentTileIndex += diceValue;


                // 플레이어가 샛별칸 지났는지 체크
                int passedStarTileNum = currentTileIndex / 5 - previousTileIndex / 5;
                if (passedStarTileNum > 0)
                {
                    for (int i = 0; i < passedStarTileNum; i++)
                    {
                        int starTileindex = (currentTileIndex / 5 - i) * 5;

                        if(starTileindex > totalTile)
                            starTileindex -= totalTile;

                        int starTileIndex = passedStarTileNum * 5;
                        TileInfo_Star tileInfo_Star = (TileInfo_Star)map.mapInfo.GetValueOrDefault(starTileIndex);
                        if (tileInfo_Star != null)
                        {
                            currentStarPoint += tileInfo_Star.starValue;
                        }
                    }
                    
                }

                // [12] 칸 넘었을 때
                if (currentTileIndex > totalTile )
                {
                    currentTileIndex -= totalTile;
                }

                
                Console.WriteLine($"현재 플레이어 위치: {currentTileIndex}");

                // [13]
                // 현재 칸의 정보를 받아옴.
                TileInfo info = map.mapInfo.GetValueOrDefault(currentTileIndex);
                if (info == null)
                {
                    // Failed to get tileinfo. Check parameters.
                    Console.WriteLine($"Failed to get tileinfo. num: {currentTileIndex}.");
                    return;
                }
                info.TileEvent(); // 칸의 이벤트 호출

               

                previousTileIndex = currentTileIndex;
                Console.WriteLine($"현재 샛별 점수 : {currentStarPoint}.");
                Console.WriteLine($"남은 주사위 갯수 : {currentDiceNum}.");
            }

            Console.WriteLine($"Game Finished! You got total {currentStarPoint} stars.");
        } // main
        // [11]
        static int RollADice()
        {
            // string userInput = Console.ReadLine();
            // [10]
            string userInput = "Default";
            while (userInput != "")
            {
                Console.WriteLine("Roll A Dice ! Press Enter");
                userInput = Console.ReadLine();
            }

            random = new Random();
            int diceValue = random.Next(1, 7);
            Console.WriteLine($"DiceValue : {diceValue}");
            DisplayDice(diceValue);

            return diceValue;
        }


        // [9]
        static void DisplayDice(int diceValue)
        {
            switch (diceValue)
            {
                case 1:
                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│     ●    │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("└───────────┘");
                    break;
                case 2:
                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│ ●        │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│         ●│");
                    Console.WriteLine("└───────────┘");
                    break;
                case 3:
                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│ ●        │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│     ●    │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│         ●│");
                    Console.WriteLine("└───────────┘");
                    break;
                case 4:
                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("└───────────┘");
                    break;
                case 5:
                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│     ●    │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("└───────────┘");
                    break;
                case 6:
                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("└───────────┘");
                    break;
                default:
                    break;
            }
        }
    }
}
