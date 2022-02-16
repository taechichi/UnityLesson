using System;
using System.Collections.Generic;

namespace _220216_REVIEW_16_UnityLesson_CSharp_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            // ====================================
            // List
            // ====================================

            List<int> _list = new List<int>();
            _list.Add(3);
            _list.Add(2);
            _list.Add(1);
            _list.Add(0);
            _list.Add(3);

            int _list_length = _list.Count;
            
            for (int count = 0; count < _list_length; count++)
            {
                Console.WriteLine(_list[count]);
            }
            Console.WriteLine("==================");


            // 0번째 인덱스부터 탐색하고, 첫번째로 파라미터와 같은 요소를 발견하면 삭제.
            // 삭제 성공시 true 반환, 아니면 false 반환
            _list.Remove(3);

            _list_length = _list.Count;
            for (int count = 0; count < _list_length; count++)
            {
                Console.WriteLine(_list[count]);
            }
            Console.WriteLine("==================");


            // foreach 는 collection 이 가지고 있는 타입의 아이템만큼
            // 반복문을 실행하면서 각 아이템을 반환해준다.

            foreach(int num in _list)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("==================");

            List<Orc> _list_Orc = new List<Orc>();
            foreach (var val in _list_Orc)
            {
                
            }
            Console.WriteLine("==================");


            // ====================================
            // Dictionary
            // ====================================

            Dictionary<string, string> _dic = new Dictionary<string, string>();
            _dic.Add("검사", "양손대검을 사용하여 물리공격을 하는 클래스");
            _dic.Add("마법사", "지팡이를 사용하여 마법공격을 하는 클래스");
            _dic.Add("수호자", "창과 방패를 사용하여 물리공격 및 방어를 하는 클래스");
            // _dic.Remove("검사");

            bool isSwordMasterExist = _dic.ContainsKey("검사");
            if(isSwordMasterExist)
            {
                string tmpValue = _dic["검사"];
                Console.WriteLine($"검사: {tmpValue}");
            }
            else
            {
                Console.WriteLine($"검사가 없습니다.");
            }
            Console.WriteLine("==================");

            // dictionary 도 foreach 구문이 가능하다.
            // dictionary 도 collection 이고
            // dictionary 에서 Keys 를 가져오면 KeyCollection 을 가져올 수 있고
            // dictionary 에서 Values 를 가져오면 ValueCollection 을 가져올 수 있다.
            // 즉, dictionary 자체도, key, value 각각도 foreach 구문이 가능하다.

            // dictionary.Keys 를 foreach 문 실행
            foreach(string val in _dic.Keys)
            {
                string tmpValue = _dic[val];
                Console.WriteLine($"{val} : {tmpValue}");
            }
            Console.WriteLine("==================");

            // dictionary 를 foreach 문 실행
            foreach(KeyValuePair<string, string> val in _dic)
            {
                string tmpKey = val.Key;
                string tmpVal = val.Value;

                Console.WriteLine($"{tmpKey} : {tmpVal}");
                Console.WriteLine(val);
            }
            Console.WriteLine("==================");
        }
    }

    class Orc
    {

    }
}
