using System;
using System.Collections.Generic;

namespace _220205_UnityLesson_CSharp_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=====================================================================
            // List
            //=====================================================================

            List<int> _list = new List<int>();
            _list.Add(3);
            _list.Add(2);
            _list.Add(1);
            _list.Add(0);
            _list.Add(3);

            // 0번째 인덱스부터 탐색하고, 첫번째로 파라미터(매개변수)와 같은 요소를 발견하면 삭제.
            // 삭제 성공시 true 값을 반환, 아니면 false 반환
            _list.Remove(3);

            int _list_length = _list.Count;
            for (int c_i = 0; c_i < _list_length; c_i++)
            {
                Console.WriteLine(_list[c_i]);
            }

            // foreach는 collection(_list) 이 가지고 있는 타입의 아이템만큼
            // 반복문을 실행하면서 각 아이템을 반환해준다.
            foreach (int num in _list)
            {
                Console.WriteLine(num);
            }
        }
    }
}
