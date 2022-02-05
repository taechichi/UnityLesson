using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CSharp_Operator
{
    static public class OperatorMethods
    {
        // 산술 연산
        // ======================================================
        // 더하기
        static public int Sum(int a, int b)
        {
            // Console.Write($"a: {a} + b: {b} = ");
            return a + b;
        }

        // 빼기
        static public int Min(int a, int b)
        {
            return a - b;
        }

        // 곱하기
        static public int Mul(int a, int b)
        {
            return (a) * (b);
        }

        // 나누기
        static public float Div(int a, int b)
        {
            return (float)a / (float)b;
        }


        static public float DivForFloat(float a, float b)   // 자료형 마다 만들어줘야하나? 아주 불편하다;;
        {
            return a / b;
        }

        // 하지만 그럴필요가 없다
        // 오버로드을 쓰면된다! 아주편하다.
        static public float Div(float a, float b)
        {
            return a / b;
        }

        // 나머지
        static public int Mod(int a, int b)
        {
            return a % b;
        }

        // 증감 연산
        // ======================================================
        // 증가 연산자 ** 해당 문장이 끝난 후에 1증가
        static public float Increase(float a)
        {
            a += 1;
            return a;
        }

        // 감소 연산자 ** 해당 문장이 끝난 후에 1감소
        static public float Decrease(float a)
        {
            a -= 1;
            return a;
        }

        // 관계 연산
        // ======================================================
        // 같은지 비교
        static public bool IsSame(int a, int b)
        {
            return a == b;
        }

        // 다른지 비교
        static public bool IsDiffer(int a, int b)
        {
            return a != b;
        }

        // 큰지 비교
        static public bool IsBigger(int a, int b)
        {
            return a > b;
        }
        
        // 크거나 같은지 비교
        static public bool IsBiggerOrSame(int a, int b)
        {
            return a >= b;
        }

        // 작은지 비교
        static public bool IsSmaller(int a, int b)
        {
            return a < b;
        }

        // 작거나 같은지 비교
        static public bool IsSmallerOrSame(int a, int b)
        {
            return a <= b;
        }


        // 논리 연산
        // ======================================================

        // or
        static public bool LogicOR(bool A, bool B)
        {
            return A | B;
        }

        // and
        static public bool LogicAND(bool A, bool B)
        {
            return A & B;
        }

        // xor
        static public bool LogicXOR(bool A, bool B)
        {
            return A ^ B;
        }
        
        // not
        static public bool LogicNOT(bool A)
        {
            return !A;
        }

        // 조건부 논리연산
        // ======================================================
        // conditional or
        static public bool LogicConOR(bool A, bool B)
        {
            return A || B;
        }
        // conditional and
        static public bool LogicConAND(bool A, bool B)
        {
            return A && B;
        }

        // 비트연산
        // ======================================================
        // or
        static public int BitLogicOR(int a, int b)
        {
            return a | b;
        }

        // and
        static public int BitLogicAND(int a, int b)
        {
            return a & b;
        }

        // xor
        static public int BitLogicXOR(int a, int b)
        {
            return a ^ b;
        }

        // not
        static public int BitLogicNOT(int a)
        {
            return ~a;
        }

        // shift - left
        static public int BitShiftLeft(int a, int howManyBitsYouWantToShift)
        {
            return a << howManyBitsYouWantToShift;
        }

        // shitf - right
        static public int BitShiftRight(int a, int howManyBitsYouWantToShift)
        {
            return a >> howManyBitsYouWantToShift;
        }
    }
}
