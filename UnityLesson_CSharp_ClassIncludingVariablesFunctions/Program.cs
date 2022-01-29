using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CSharp_ClassIncludingVariablesFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        // CamelCase 낙타 케이스 후훟ㅎ후
        // 단어가 바뀔때 첫 문자는 대문자로 한다.
        // 변수는 시작할 때 소문자로 시작한다.
        // class 나 method나 namespace 등은 대문자로 시작한다.
        // 코드 작성시 유의사항
        /*
         * 줄임말은 되도록 사용하지 않는다.
         * 이름을 보았을 때 어떤 기능이나 목적인지 알 수 있도록 선정한다.
         * 애매하거나 복잡한 내용이 있으면 주석을 꼭꼭 달아준다.
         * 띄어쓰기 할때는 __ underbar를 쓰세용
         */
        /*
         * 글씨 쓰는 규약 암묵적인 룰
         * void DestroyEnemy()
         * void Destroyenemy()
         * void destroyenemy()
         */

        //  클래스 정의 형태
        /*
        class 클래스이름
        {
            멤버변수
            멤버함수
        }
        */

        class Person
        {
            int age;
            float height;
            bool isResting;
            char genderChar;
            string name;

            void SayAllInfo()
            {
                SayAge();
                SayHeight();
                SayIsResting();
                SayGenderChar();
                SayName();
            }


            void SayAge()
            {
                Console.WriteLine($"{name}의 나이 : {age}");
            }

            void SayHeight()
            {
                Console.WriteLine($"{name}의  키 : {height}");
            }

            void SayIsResting()
            {
                Console.WriteLine($"{name}은 쉬고있나? : {isResting}");
            }

            void SayGenderChar()
            {
                Console.WriteLine($"{name}의 성별 : {age}");
            }

            void SayName()
            {
                Console.WriteLine(name);
            }
        }
    }
}
