using System;
using System.Collections.Generic;

namespace _220219_5week_01_UnityClass_CSharp_ClassInheritance
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Creature creature1 = new Creature();

            // 숨 열번쉬기
            for (int count = 0; count < 10; count++)
            {
                creature1.Breath();
            }
            Console.WriteLine(creature1.age);
            Console.WriteLine("=====================");


            // 상속되었는지 확인하자.
            Human human1 = new Human();

            // 숨 열번쉬기
            for (int count = 0; count < 10; count++)
            {
                human1.Breath();
            }
            Console.WriteLine($"age: {human1.age}, height: {human1.height}, weight: {human1.weight}");
            Console.WriteLine("=====================");

            Dog dog1 = new Dog();
            dog1.tailLength = 1f;
            Console.WriteLine("=====================");


            // ex2)
            // B, W, Y 20 people create
            WhiteMan[] arr_WhiteMan = new WhiteMan[20];
            BlackMan[] arr_BlackMan = new BlackMan[20];
            YellowMan[] arr_YellowMan = new YellowMan[20];

            int arr_WhiteMan_Length = arr_WhiteMan.Length;
            int arr_BlackMan_Length = arr_BlackMan.Length;
            int arr_YellowMan_Length = arr_YellowMan.Length;

            // 생성자로 생성
            for(int count = 0; count < arr_WhiteMan_Length; count++)
            {
                arr_WhiteMan[count] = new WhiteMan();
                arr_BlackMan[count] = new BlackMan();
                arr_YellowMan[count] = new YellowMan();

                arr_WhiteMan[count].TwoLeggedWalk();
                arr_BlackMan[count].TwoLeggedWalk();
                arr_YellowMan[count].TwoLeggedWalk();

                Console.WriteLine($"{count}");
            }
            Console.WriteLine("=====================");


            // 선생님 예제 답안 - > 리스트로 하심..ㅎ
            // ===============================================
            // case : 각 인종에 대한 리스트 별개로 생성하기

            List<WhiteMan> whiteMen = new List<WhiteMan>();
            List<BlackMan> blackMen = new List<BlackMan>();
            List<YellowMan> yellowMen = new List<YellowMan>();

            for (int count = 0; count < 20; count++)
            {
                WhiteMan tmpMan = new WhiteMan();
                whiteMen.Add(tmpMan);
            }

            for(int count = 0; count < 20; count++)
            {
                BlackMan tmpMan = new BlackMan();
                blackMen.Add(tmpMan);
            }

            for (int count = 0; count < 20; count++)
            {
                YellowMan tmpMan = new YellowMan();
                yellowMen.Add(tmpMan);
            }

            foreach (var item in whiteMen)
            {
                item.TwoLeggedWalk();
            }
            foreach (var item in blackMen)
            {
                item.TwoLeggedWalk();
            }
            foreach (var item in yellowMen)
            {
                item.TwoLeggedWalk();
            }
            Console.WriteLine("=====================");

            // WhiteMan 객체화 -> Human 응로 인스턴스화
            // Human변수에 있는 Breath 를 호출하면 WhiteMan에 있는 Breath 가 호출됨
            // 
            // 자식 객체를 부모 클래스타입으로 인스턴스화 시키고
            // 해당 변수의 virtual 멤버 함수를 호출하면
            // 자식 객체의 override 된 함수가 호출된다.
            Human testhuman = new WhiteMan();
            testhuman.Breath();
            Console.WriteLine($"{testhuman.height}, {testhuman.weight}");
            Console.WriteLine("=====================");

            // 중요하다 -> 코드를 깔끔하고 효율적으로 관리할 수 있다. -> 객체 지향이 각광받는 부분 중 하나!
            // 위 성질을 이용하여

            // case : 위 성질을 이용하여 부모클래스(Human) 리스트 하나만 생성
            List<Human> humen = new List<Human>();

            for(int count = 0; count < 20; count++)
            {
                Human tmpWHuman = new WhiteMan();
                humen.Add(tmpWHuman);

                Human tmpBHuman = new BlackMan();
                humen.Add(tmpBHuman);

                Human tmpYHuman = new YellowMan();
                humen.Add(tmpYHuman);
            }

            foreach (var item in humen)
            {
                item.TwoLeggedWalk();
            }
            Console.WriteLine("=====================");

            // 인터페이스 인스턴스화 예시
            ITwoLeggedWalker iTwoLeggedWalker = new WhiteMan();
            iTwoLeggedWalker.TwoLeggedWalk();
            // -> 이러면 WhiteMan이 걷는거임;
            // case : 인터페이스로 인스턴스화 시키는 방법
            // 메모리 크기를 크게 아낄수있다. -> 이런게 최적화지 지려따... 최소한의 요소로 프로그래밍해야 효율적으로 관리할 수 있따.
            // 이것이 인터페이스를 사용하는 가장 큰 이유.. 멋있따...
            // 근데 메모리가 점점 커져서 의미가 퇴색되긴하지만 굉장이 효율적이다!!

            List<ITwoLeggedWalker> walkers = new List<ITwoLeggedWalker>();
            for (int count = 0; count < 20; count++)
            {
                ITwoLeggedWalker iTwoLeggedWalker_W = new WhiteMan();
                walkers.Add(iTwoLeggedWalker_W);

                ITwoLeggedWalker iTwoLeggedWalker_B = new BlackMan();
                walkers.Add(iTwoLeggedWalker_B);

                ITwoLeggedWalker iTwoLeggedWalker_Y = new YellowMan();
                walkers.Add(iTwoLeggedWalker_Y);
            }

            foreach (var item in walkers)
            {
                item.TwoLeggedWalk();
            }
            Console.WriteLine("=====================");



        } // main
    } // internal program
} // namespace
