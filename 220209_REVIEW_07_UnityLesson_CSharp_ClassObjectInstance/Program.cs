using System;

namespace _220209_REVIEW_07_UnityLesson_CSharp_ClassObjectInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            // AA 객체 생성
            // new 키워드
            new AA();   // 생성자 : 클래스 이름과 똑같은 함수. 객체를 생성하고 반환함
            // ㄴ 힙영역에 할당

            // 인스턴스화
            // 메모리 공간에 객체를 할당시킨다.
            // new AA() 로 생성된 객체를 반환한 값(객체)이 AA타입변수 aa에 할당 되었다.
            // 이렇게 하면 aa 변수를 통해서 생성된 객체에 접근할 수 있게 된다.
            // 여기서 새로 생성된 객체가 할당된 aa 변수를 인스턴스 라고 한다.
            AA aa = new AA();
            // 힙영역에 할당된 인스턴스를 참조하기위해 스택영역에다가 할당시켜준다.
            // AA aa (스택영역) // new AA(); (힙영역)
            
        }
    }
}

public class AA
{
    public AA()
    {

    }

    // 생성자도 오버로드가 가능하다.
    public AA(int a)
    {

    }
    
    // C#에는 없는데 원래 소멸자라는 애가 있다.
    ~AA()
    {

    }


}
