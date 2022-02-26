using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220226_Teacher_HorseRacing
{
    internal class Horse
    {
        // [2]
        public string name;
        public int distance;

        // [3]
        public bool available = true;        // 얘가 true면 달리고 false면 안달리고,

        public void Run(int moveDistance)
        {
            if(available)
            {
                distance += moveDistance;
            }
            else
            {
                // nothing
            }
            
        }
    }
}
