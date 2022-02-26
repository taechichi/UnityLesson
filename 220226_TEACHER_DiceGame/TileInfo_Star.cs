using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220226_TEACHER_DiceGame
{
    internal class TileInfo_Star : TileInfo
    {
        // 3
        public int starValue = 3;
        public override void TileEvent()
        {
            base.TileEvent();
            starValue++;
        }
    }
}
