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

            Console.WriteLine($"=====");

            // foreach는 collection(_list) 이 가지고 있는 타입의 아이템만큼
            // 반복문을 실행하면서 각 아이템을 반환해준다.
            foreach (int num in _list)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine($"=====");

            /*
            List<Orc> list_Orc = new List<Orc>();
            foreach (Orc item in list_Orc)
            {

            }
            */


            //=====================================================================
            // Dictionary
            //=====================================================================
            Dictionary<string, string> _dic = new Dictionary<string, string>();
            _dic.Add("검사", "양손대검을 사용하여 물리공격을 하는 클래스");
            _dic.Add("마법사", "지팡이를 사용하여 마법공겨을 하는 클래스");
            _dic.Add("수호자", "창과 방패를 사용하여 물리공격 및 방여 위주의 클래스");
            // _dic.Remove("검사"); // Tkey 만 입력하면 삭제가능.

            // 해당 단어가 있느지 체크하는 함수
            bool IsSwordMasterExist = _dic.ContainsKey("검사"); // 반환값으로 비교같은거 함
            if(IsSwordMasterExist)
            {
                string tmpValue = _dic["검사"]; // 있으면 dic에서 가져옴. 식별자가 string이라 가능 ("검사") index에 접근 그 공간에 있는 값을 가져옴.
                // "검사"가 아닌 다른 문자를 입력하면 오류가 난다 마치, 0~5index에서 7번쨰 인덱스를 가져오라 명령하는 것과 같다. 알맞은 인덱스를 가져오자.
                Console.WriteLine($"검사 : {tmpValue}");
            }
            else
            {
                Console.WriteLine($"검사가 없는데요?");
            }

            Console.WriteLine($"=====");

            // dictionary 도 당연히 foreach 구문이 가능하다.
            // dictionary 는 collection 이고
            // dictionary 에서 Keys 를 가져오면 KeyCollection 을 가져올수있고
            // dictionary 에서 Values 를 가져오면 ValuesCollection 을 가져올수있다.
            // key 첫번째에 검사가 들어가고 value 첫번째에 "양손~"이 들어간다. list 들어가듯이
            // 즉, dictionary 자체도 key, value 각각도 foreach 구문이 가능하다.


            // dictionary.Keys 를 foreach 문 실행
            foreach (string sub in _dic.Keys)
            {
                string tmpValue = _dic[sub];
                Console.WriteLine($"{sub} : {tmpValue}");
            }
            Console.WriteLine($"=====");


            // dictionary.Values 를 foreach 문 실행
            foreach (string sub in _dic.Values)
            {
                Console.WriteLine(sub);    
            }
            Console.WriteLine($"=====");



            // dictionary 를 foreach 문 실행
            foreach (KeyValuePair<string, string> sub in _dic)
            {
                string tmpKey = sub.Key;
                string tmpValue = sub.Value;
                Console.WriteLine($"{tmpKey} : {tmpValue}");
                Console.WriteLine(sub);
            }
            Console.WriteLine($"=====");



            //=====================================================================
            // Queue (List 와 비슷하나, FIFO, First Input First Output 체계이다)
            //=====================================================================

            Queue<int> _queue = new Queue<int>();

            _queue.Enqueue(10); //_queue.Enqueue(넣고싶은거);
            _queue.Enqueue(20);
            _queue.Enqueue(30);
            Console.WriteLine(_queue.Peek()); // peek은 제일 앞에 있는애가 뭔지 알랴줌.

            // _queue.Dequeue(); // parameter를 넣지 않는다. Queue 니깐! FIFO 체계니까
            Console.WriteLine(_queue.Dequeue());
            Console.WriteLine(_queue.Dequeue());
            Console.WriteLine(_queue.Dequeue());
            Console.WriteLine($"=====");


            //=====================================================================
            // Stack (List 와 비슷하나, LIFO, Last Input First Output 체계이다)
            //=====================================================================

            Stack<int> _stack = new Stack<int>();

            _stack.Push(10);
            _stack.Push(20);
            _stack.Push(30);

            Console.WriteLine(_stack.Peek()); // queue 에서는 제일 앞이지만 stack에서는 나중
            Console.WriteLine(_stack.Pop()); // 제일 마지막에 넣은 애가 나옴
            Console.WriteLine(_stack.Pop());
            Console.WriteLine(_stack.Pop());

        }
    }
    class Orc
    {

    }
}
