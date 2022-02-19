using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220219_5week_01_UnityClass_CSharp_ClassInheritance
{
    internal class YellowMan : Human
    {
        public override void Breath()
        {
            // 과연 base가 뭘까 -> 마우스를 올려보렴
            // base.Breath();
            // Human 의 Breath 이다.
            height += 0.00004f;
            weight += 0.00007f;
            // 이렇게만 하면 Human 의 Breath()의 height weight와 중복이다.
            // 이럴땐
            // base.Breath(); 쓰지 말고
            // 그냥
            age++;

            // 더 좋은 방법은 오버라이드를 않는게 좋다.
        }
    }
}
