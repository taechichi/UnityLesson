using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220226_ASSIGNMENT_tmp_HorseRacing
{
    internal class Horse
    {
        public string name;
        public float distance;

        public void horseRacing(float horseRunDistance)
        {
            distance += horseRunDistance;
        }
    }
    
}
