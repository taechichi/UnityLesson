using System;

namespace _220209_REVIEW_11_UnityLesson_CSharp_Operator
{
    static public class OperatorMethods
    {
        // 산술 연산
        // =======================================================================
        // 더하기
        static public int Sum(int a, int b)
        {
            return a + b;
        }

        // 빼기
        static public int Sub(int a, int b)
        {
            return a - b;
        }

        // 나누기
        static public int Div(int a, int b)
        {
            return a / b;
        }

        // 곱하기
        static public int Mul(int a, int b)
        {
            return a * b;
        }

        // 나머지
        static public int Mod(int a, int b)
        {
            return a % b;
        }

        // 증감 연산
        // =======================================================================
        // 증가 연산자
        static public int Increase(int a)
        {
            a++;    // 증감 연산자는 해당 문장이 끝난 후에 1 증가 시킴.
            return a;
        }

        // 감소 연산자
        static public int Decrease(int a)
        {
            a--;
            return a;
        }

        // 관계 연산
        // =======================================================================
        // 같은지 비교
        static public bool IsSame(int a, int b)
        {
            return a == b;
        }

        // 다른지 비교
        static public bool IsDifferent(int a, int b)
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
            return a <= b;
        }

        // 작거나 같은지 비교
        static public bool IsSmallerOrSame(int a, int b)
        {
            return a <= b;
        }

        // 논리 연산
        // =======================================================================
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
        // =======================================================================
        // or
        static public bool ConditionalLogicOR(bool A, bool B)
        {
            return A || B;
        }

        // and
        static public bool ConditionalLogicAND(bool A, bool B)
        {
            return A && B;
        }

        // 비트 연산
        // =======================================================================
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

        // shift - right
        static public int BitShitfRight(int a, int howManyBitsYouWantToShift)
        {
            return a >> howManyBitsYouWantToShift;
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            int a = 14;
            int b = 5;
            int c = 0;

            Console.WriteLine($"a: {a}, b: {b}, c: {c}.");
            // 산술 연산
            // 더하기, 빼기, 나누기**(몫반환), 곱하기, 나머지(몫 제외 나머지 반환)
            // =======================================================================
            // 더하기
            c = OperatorMethods.Sum(a, b);
            Console.Write($"a + b = {c} ");

            // 빼기
            c = OperatorMethods.Sub(a, b);
            Console.WriteLine($"a - b = {c} ");

            // 나누기
            c = OperatorMethods.Div(a, b);
            Console.WriteLine($"a / b = {c} ");

            // 곱하기
            c = OperatorMethods.Mul(a, b);
            Console.WriteLine($"a * b = {c} ");

            // 나머지
            c = OperatorMethods.Mod(a, b);
            Console.WriteLine($"a % b = {c} ");


            // 증감 연산
            // 증가 연산자, 감소 연산자
            // =======================================================================
            Console.WriteLine("=======================================================================");
            Console.WriteLine($"a : {a}");

            // 증가 연산자
            c = OperatorMethods.Increase(a);
            Console.WriteLine($"a++ : {c}");

            // 감소 연산자
            c = OperatorMethods.Decrease(a);
            Console.WriteLine($"a-- : {c}");

            // 관계 연산
            // 수학에서 등화와 부등화
            // 같음, 다름, 크기 비교 연산 수행
            // 관계 연산 결과가 참이면 true, 거짓이면 false 반환
            // =======================================================================
            Console.WriteLine("=======================================================================");
            Console.WriteLine($"a: {a}, b: {b} bool result 추가");

            bool result;
            // 같음 비교
            result = a == b;
            Console.WriteLine($" a == b : {result}");

            // 다름 비교
            result = a != b;
            Console.WriteLine($" a != b : {result}");

            // 크다
            result = a > b;
            Console.WriteLine($" a > b : {result}");

            // 크거나 같다
            result = a >= b;
            Console.WriteLine($" a >= b : {result}");

            // 작다
            result = a < b;
            Console.WriteLine($" a < b : {result}");

            // 작거나 같다
            result = a <= b;
            Console.WriteLine($" a <= b : {result}");

            // 논리 연산 (논리 자료형 연산 - bool 형끼리의 연산)
            // 양측의 피연산자들을 비교해서 연산 수행
            // or, and, xor, not
            // =======================================================================
            Console.WriteLine("=======================================================================");
            Console.WriteLine("bool A = true, bool B = false");

            bool A = true;
            bool B = false;

            // or
            // a 와 b 둘 중 하나라도 true 이면 true 반환, 나머지는 false
            result = A | B;
            Console.WriteLine($"A | B : {result}");

            // and
            // a 와 b 둘다 true 이면 true 반환, 나머지는 false
            result = A & B;
            Console.WriteLine($"A & B : {result}");

            // xor
            // a 와 b 둘중 하나만 true 일 때 true 반환, 나머지는 false (둘이 달라야)
            result = A ^ B;
            Console.WriteLine($"A ^ B : {result}");

            // not
            // a의 반대 부호 반환 (true 이면 false, false 이면 true 반환)
            result = !A;
            Console.WriteLine($"!A : {result} ");


            // 조건부 논리연산
            // 왼쪽 피연산자 조건에 따라서 오른쪽 피연산자와 비교할지 말지 평가 후에 연산
            // =======================================================================
            Console.WriteLine("=======================================================================");
            Console.WriteLine("bool A = true, bool B = false");

            // conditional or
            // 만약 A 가 true 이면 B의 값에 관계없이 결과값이 true 이므로
            // 연산을 수행하지 않고 A를 반환함.
            result = A || B;
            Console.WriteLine($" A || B : {result}");

            // conditional and
            // 만약 A가 false 면 B의 값에 관계없이 결과값이 false 이므로
            // 연산을 수행하지 않고 A를 반환함
            result = A && B;
            Console.WriteLine($" A && B : {result}");


            // 비트 연산
            // 비트 연산을 하는 이유 : 데이터를 효율적으로 관리하기 위함
            // or, and, xor, not, shift-left, shift-right
            // =======================================================================
            Console.WriteLine("=======================================================================");
            int howManyBitsYouWantToShift = 3;
            Console.WriteLine($"howManyBitsYouWantToShift : 3 ");
            Console.WriteLine($"a: {a}, b: {b}, c: {c}.");
            // or
            c = a | b;
            Console.WriteLine($"a | b : {c}");

            // and
            c = a & b;
            Console.WriteLine($"a & b : {c}");

            // xor
            c = a ^ b;
            Console.WriteLine($"a ^ b : {c}");

            // not
            c = ~a;
            Console.WriteLine($"~a : {c}");

            // shift-left
            c = a << howManyBitsYouWantToShift;
            Console.WriteLine($"a << howManyBitsYouWantToShift : {c}");

            // shift-right
            c = a >> howManyBitsYouWantToShift;
            Console.WriteLine($"a >> howManyBitsYouWantToShift : {c}");
        }
    }
}
