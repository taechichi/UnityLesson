using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220219_5week_01_UnityClass_CSharp_ClassInheritance
{
    internal class Creature
    {
        public string DNA;
        public float age;
        public float weight;

        // 함수 오버라이드를 하기 위해서는 부모함수에 virtual 키워드 입력
        // virtual 키워드 : 해당 함수를 오버라이딩 가능하도록 해준다.
        // 부모 클래스 함수라고 해서 전부 virtual 붙이는게 아니라
        // 자식 클래스가 해당 함수를 재정의 해야할 필요성이 있을 때만 virtual 붙여줌
        // public 도 그러하다. -> 다른 곳에서 접근해야할 필요성이 있을때
        // 사실 모든 키워드가 그러하다.
        virtual public void Breath()
        {
            age++;
        }
        // -> 오버라이드 가능한 함수가 되었다!
    }
}
