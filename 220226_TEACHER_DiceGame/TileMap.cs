﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220226_TEACHER_DiceGame
{
    // 4
    // 게임 시작시 맵을 생성하고 (칸들 생성)
    // 맵에 대한 정보를 가지고 있을 클래스

    internal class TileMap
    {
        // 7
        public Dictionary<int, TileInfo> mapInfo = new Dictionary<int, TileInfo>();

        // 5
        public void MapSetup(int maxTileNum)
        {
            for (int i = 1; i <= maxTileNum; i++)
            {
                //6
                // 5배수, 즉 샛별칸을 생성함
                if(i%5 == 0 )
                {
                    TileInfo tileInfo_Star = new TileInfo_Star();
                    tileInfo_Star.index = i;
                    tileInfo_Star.name = "Star";
                    tileInfo_Star.discription = "This is star tile.";
                    mapInfo.Add(i, tileInfo_Star);
                }
                // 일반칸을 생성함
                else
                {
                    TileInfo tileinfo = new TileInfo();
                    tileinfo.index = i;
                    tileinfo.name = "Dummy";
                    tileinfo.discription = "This is dummy tile";
                    mapInfo.Add(i, tileinfo);
                }
            }
            Console.WriteLine($"Maps setup complete. Max tile num {maxTileNum}");
        }
    }
}