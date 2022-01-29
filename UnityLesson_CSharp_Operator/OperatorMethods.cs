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
            return (a * b);
        }

        // 나누기
        static public float Div(int a, int b)
        {
            return (float)a / (float)b;
        }
        // 나머지
        static public int Rim(int a, int b)
        {
            return a % b;
        }

        // 논리 연산
        // ======================================================

        // or
        static public bool LogicOr(bool A, bool B)
        {
            return A | B;
        }

        // and
        static public bool LogicAnd(bool A, bool B)
        {
            return A & B;
        }

        // xor
        static public bool LogicXor(bool A, bool B)
        {
            return A ^ B;
        }
        
        // not
        static public bool LogicNot(bool A)
        {
            return !A;
        }

        // 조건부 논리연산
        // ======================================================
        // conditional or
        static public bool LogicConOr(bool A, bool B)
        {
            return A || B;
        }
        // conditional and
        static public bool LogicConAnd(bool A, bool B)
        {
            return A && B;
        }
    }
}
