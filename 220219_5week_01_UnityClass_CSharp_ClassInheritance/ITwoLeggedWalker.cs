﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220219_5week_01_UnityClass_CSharp_ClassInheritance
{
    // Interface
    // 클래스랑 비슷하게 생겼지만
    // 함수, 이벤트, 인덱서, 속성(Attribute) 만 멤버로 가질 수 있고
    // 각 멤버는 접근제한자가 기본적으로 public 
    // 각 멤버들은 선언만 할 뿐 정의를 하지 않는다.
    // 클래스와 다르게 다중상속이 가능한다. ( 한 클래스가 여러개의 인터페이스를 상속받을 수 있다.)
    // 클래스 추상화 할 때, 여러 클래스들의 함수드링 똑같은 이름으로 필요한 경우, 인터페이스로 묶어서 따로 관리할 수 있다.
    // 인터페이스를 상속받은 클래스는 인터페이스에 정의된 모든 멤버를 멤버로 가지고 있어야한다.

    // 인터페이스는 가능한 한 세분화를 많이 할수록 좋다. -> 나중에 필요한 동작을 인스턴스화 시켜서 돌릴때, 메모리차원에서 효율적이기때문에,
    // 파일이 많아지더라도 인터페이스가 많은 것이 좋다
    // 
    internal interface ITwoLeggedWalker
    {
        public void TwoLeggedWalk();
    }
}
