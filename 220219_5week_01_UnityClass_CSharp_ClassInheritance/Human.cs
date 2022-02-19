using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220219_5week_01_UnityClass_CSharp_ClassInheritance
{
    // 상속받는 법 ( : ) 하고 ( 클래스 이름 ) 적기
    internal class Human : Creature, ITwoLeggedWalker
    {
        public float height;
        public float heightGrowthSpeed = 0.00004f;
        public float weightGrowthSpeed = 0.00002f;
        // override 키워드 쓰고 해당함수 선택하면..!
        // override : 부모의 virtual 키워드가 붙은 함수를 재정의 하는 키워드
        public override void Breath()
        {
            base.Breath();      // 이게없으면 기존 부모 내용은 없어짐. 있으면 실행함.
            height += 0.0004f;
            weight += 0.0002f;
        }
        // -> 숨쉬기 함수를 재정의했다!

        public void TwoLeggedWalk()
        {
            Console.WriteLine("두발로 걷는다.");
        }
    }
}
