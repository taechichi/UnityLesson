using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220219_5week_01_UnityClass_CSharp_ClassInheritance
{
    internal class WhiteMan : Human
    {
        public override void Breath()
        {
            age++;
            weight += 0.0006f;
            height += 0.0004f;
        }
    }
}
