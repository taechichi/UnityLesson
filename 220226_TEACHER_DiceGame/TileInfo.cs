using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220226_TEACHER_DiceGame
{
    internal class TileInfo
    {
        // 2
        public int index;           // 몇번째 칸인지에 대한 번호
        public string name;
        public string discription;  // 도스창에 특정 칸에 대한 설명

        virtual public void TileEvent()
        {
            Console.WriteLine($"Tile number : {index}, The Player is On {name}, {discription}");
        }
    }
}
