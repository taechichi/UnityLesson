﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220219_5week_01_UnityClass_CSharp_ClassInheritance
{
    internal class BlackMan : Human
    {
        public override void Breath()
        {
            age++;
            height += 0.00007f;
            weight += 0.00005f;
        }
    }
}
