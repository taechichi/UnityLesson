using System;
// switch-case 에 적합한 형태,
// 각 요소들이 동시에 일어나는 경우가 없는 상황에 적합한 형태
// 특히 FSM (Finite State Machine)
//

enum e_PlayerState
{
    Idle,       // ...0000 0000
    Attack,     // ...0000 0001
    Jump,       // ...0000 0010
    Walk,       // ...0000 0011
    Run,        // ...0000 0100
    Dash,       // ...0000 0101
    Home,       // ...0000 0110
    DashAttack, // ...0000 0111
}

// 각 요소들이 동시에 일어나는 경우가 있는 상황에 적합한 형태
[Flags] // ToString() 속성을 참조할때 중복되는 모든 요소들에 대해 표현이 가능(문자열로 형변환이 가능)
enum e_PlayerStateFlags
{
    Idle = 0,           // ...0000 0000
    Attack = 1 << 0,    // ...0000 0001
    Jump = 1 << 1,      // ...0000 0010
    Walk = 1 << 2,      // ...0000 0100
    Run = 1 << 3,       // ...0000 1000
    Dash = 1 << 4,      // ...0001 0000
    Home = 1 << 5,      // ...0010 0000
}


namespace _220217_REVIEW_17_UnityLesson_CSharp_EnumAndSwitchCase
{
    class Program
    {
        // Casting 캐스팅
        // 비트 정보 그대로 들고와서 타입만 변경시킴
        static e_PlayerState createMotion = (e_PlayerState)243451; // <- Casting
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            Console.Write("생성할 전사의 이름을 입력하세요 : ");
            warrior.name = Console.ReadLine();

            // if 분기
            if(createMotion == e_PlayerState.Idle)
            {
                // do nothing
            }
            else if(createMotion == e_PlayerState.Attack)
            {
                warrior.Attack();
            }
            else if(createMotion == e_PlayerState.Jump)
            {
                warrior.Jump();
            }
            else if(createMotion == e_PlayerState.Walk)
            {
                warrior.Walk();
            }
            else if(createMotion == e_PlayerState.Run)
            {
                warrior.Run();
            }
            else if(createMotion == e_PlayerState.Dash)
            {
                warrior.Dash();
            }
            else if(createMotion == e_PlayerState.Home)
            {
                warrior.Home();
            }
            else
            {
                Console.WriteLine("어 상태가 이상해");
            }
            Console.WriteLine("===============");

            // switch-case 형태
            /*
             *  {
             *      case 경우1:
             *          이 경우에 실행할 내용
             *          break;
             *      case 경우2:
             *          이 경우에 실행할 내용
             *          break;
             *      default:
             *  }
             */

            // Switch-case 분기
            // 전사에게 동작 명령하기

            Console.WriteLine("전사에게 명령을 내려 주세요");
            string motionInput = Console.ReadLine();
            e_PlayerState motion;
            bool isParsed = Enum.TryParse(motionInput, out motion);
            if(isParsed)
            {
                switch (motion)
                {
                    case e_PlayerState.Idle:
                        // do nothing cause Idle. lol
                        break;
                    case e_PlayerState.Attack:
                        warrior.Attack();
                        break;
                    case e_PlayerState.Jump:
                        warrior.Jump();
                        break;
                    case e_PlayerState.Walk:
                        warrior.Walk();
                        break;
                    case e_PlayerState.Run:
                        warrior.Run();
                        break;
                    case e_PlayerState.Dash:
                        warrior.Dash();
                        break;
                    case e_PlayerState.Home:
                        warrior.Home();
                        break;
                     default:
                        Console.WriteLine("전사는 그런거 할줄 몰라요 응애");
                        break;
                }
            }
            else
            {
                Console.WriteLine("야 입력이 이상해");
            }
            Console.WriteLine("===============");
        }

        
    }
    public class Warrior
    {
        public string name;
        public void Attack()
        {
            Console.WriteLine($"{name} (이)가 공격함.");
        }
        public void Jump()
        {
            Console.WriteLine($"{name} (이)가 점프함.");
        }
        public void Walk()
        {
            Console.WriteLine($"{name} (이)가 걸음.");
        }
        public void Run()
        {
            Console.WriteLine($"{name} (이)가 달림.");
        }
        public void Dash()
        {
            Console.WriteLine($"{name} (이)가 돌진함.");
        }
        public void Home()
        {
            Console.WriteLine($"{name} (이)가 귀환함.");
        }
    }
}
