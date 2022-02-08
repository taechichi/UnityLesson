// keyword : Using
// using은 무언가를 사용하겠다고 선언하는 키워드
// namespace나 우선순위에서 밀린 함수, 상속관계에 의해 드러나지 않은 함수 등에
// 바로 접근하고 싶을 때 정의함
// 
// 예시1) 네임스페이스 정의
// 현재 이 클래스의 namespace는 220208_REVIEW_UnityLesson_CSharp_Variables 이기 때문에
// 다른 namespace에서 이 클래스에 접근하기 위해서는 스크립트 최상단에
// using 220208_REVIEW_UnityLesson_CSharp_Variables;
// 를 선언해주어야 함.
//
// 예시2) 우선 순위가 차순위인 함수 호출
// UnityEngine.Physics
// Unity.Physics
// 두 가지 중에 기본적으로 UnityEngine.Physics 가 우선순위
// 두 네임스페이스 모두 Raycast() 라는 함수를 포함하고 있다.
// 나는 Unity.Physics.RayCast()를 쓰고싶다.
// 일반적으로 RayCast() 를 호출하면 -> UnityEngine.Physics.Raycast()가 호출됨.
// 그.런.데
// using Raycast = Unity.Physics.Raycast;
// 라고 해주면 RayCast() 호출했을때 Unity.Physics.RayCast()가 호출됨.
using System;

// Keyword : namespace
// 클래스 간의 멤버 이름 충돌을 방지함.

namespace _220208_REVIEW_UnityLesson_CSharp_Variables
{
    // program class.
    // 모든 프로젝트는 처음 실행파일(.exe) 을 통해 실행될 때에
    // Main() 함수를 실행하며,
    // C# 에서는 Main 함수 조차도 객체지향 컨셉에 맞게 Program이라는 클래스안에 두었음.
    class Program
    {
        // Keyword : static
        // static(정적) 은 dynamic(동적) 과 반대되는 개념의 키워드로
        // "인스턴스화 시킬 수 없다" 라는 것을 의미함.
        //
        // static 은 상황, 조건에 따라 메모리에 할당할 수 없는 성질
        // dynamic 은 상황, 조건에 따라 메모리에 할당할 수 있는 성질
        //
        // Main 함수는 static 으로 정의되었으므로 하나만 존재할 수 있다.
        // static class -> 해당 클래스로 객체를 생성한 후에 메모리에 할당하고 사용하는것 등이 금지된다.
        // static method -> 이 멤버함수를 포함한 클래스가 여러개 객체화되고 메모리에 할당되어 사용되어도
        //  이 멤버함수는 클래스를 통해 접근해야하고, 해당 클래스의 모든 객체에 동일하게 적용되며
        //  인스턴스를 통해 접근할 수 없다.
        // 간단하게 말해서 static 이라는 키워드가 붙으면 객체화도 안되고 객체 단위 접근이 불가능함.
        // class 가 static 이면 객체 생성이 안되므로 멤버변수 및 함수도 전부 static 이어야 함.
        // 예)
        // static void A() {
        //      static int a;
        //      static void AMethod() {};
        //}
        // class 는 static이 아니지만 해당 클래스로 생성된 인스턴스들에 똑같이 적용시키고 싶은 멤버는
        // static으로 선언하면 됨.
        // 예) class A 는 인스턴스 가능하며, b는 인스턴스에 접근해서 수정이 가능하나
        // a와 AMethod 함수는 값 수정이 불가능해야하고 객체모두
        // 고유한 기능을 유지해야하는 경우
        // void A() {
        //      static int a;
        //      int b;
        //      static void AMethod() {};
        // }

        // void
        // 반환값의 타입이 없다.
        // 함수는 기본적으로
        // 입력 -> 기능(이득) -> 출력 의 기본 형식을 지니는데,
        // 함수에서 입력을 바탕으로한 기능만 실행하고 출력을 아무것도 하지 않는경우
        // void 라는 반환 타입을 사용한다.
        // 
        // 다른 예로, int 형을 반환하는 함수는
        // int TestInt(int intArg) {
        //      int value = intArg;
        //      ~~~ do something ~~~
        //      return value;
        //  }
        //
        // 이런 식으로 마지막에 return 뒤에 int 타입 값을 주고 반환한다.
        // 즉 위 함수는 intArg 라는 입력을 주면 어떤 동작을 한 후 내부적으로 value 라는 값을 넘겨준다.
        // void 형태의 함수는 입력을 주고 어떤 동작을 한 후 아무 값도 넘겨주지 않는다.
        //

        // args (argument)
        // 인자, 인수
        // 함수에서 받을 입력
        // 함수 이름 뒤에 괄호열고 "자료형" "인자이름" 순으로 써준다.
        // 여러 개의 입력을 넣고 싶으면 MethodName(int a, int b, int c) 처럼 써주면 된다.
        // argument 는 함수가 입력으로 받을 인자이고
        // parameter 는 함수에 입력으로 넣어줄 변수다. parameter 는 아래 함수 호출때에 다시 다룰 예정.
        static void Main(string[] args)
        {
            // Console 클래스
            // Console 에서 동작하는 기능들을 포함하고 있는 클래스

            // Console.WriteLine() 함수
            // Console 클래스가 가지고 있는 함수 중의 하나이며, 괄호 안의 Parameter 를 Console 창에 출력하고
            // 다음줄로 넘어감.

            // Console 을 더블클릭 한 후 F12 를 누르면 해당 클래스에 대한 스크립트를 볼 수 있다.
            // Console 클래스에 대한 스크립트를 보면

            // "Hello World!"
            // 문자열은 큰따옴표로 표기한다.
            // 문장이 끝날때 마다 세미콜론 (;) 을 붙여주어서 문장이 끝나나것을 알려준다.
            // 함수호출 뒤에 괄호열고 "Hello World!" 처럼 있는 것을 함수에 입력으로 넣어줄 변수 요소,
            // parameter 라고 한다.

            Console.WriteLine("Hello World!");
        }
    }
}
