using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220219_5week_01_UnityClass_CSharp_ClassInheritance
{
    internal class Dog : Creature, IFourLeggedWalker
    {
        public float tailLength;
        
        public void FourLeggedWalk()
        {
            Console.WriteLine("네발로 걷는다.");
        }
    }

}
