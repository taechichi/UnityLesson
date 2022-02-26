using System;
using System.Collections.Generic;
using System.Threading;

namespace _220226_ASSIGNMENT_tmp_HorseRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // horse creation
            List<Horse> horses = new List<Horse>();

            int horseNum = 5;
            for (int count = 0; count < horseNum; count++)
            {
                Horse tmpHorse = new Horse();
                tmpHorse.name = $"{count + 1}번마";
                horses.Add(tmpHorse);
            }

            // 5 horse ready
            foreach(Horse horse in horses)
            {
                Console.Write(horse.name);
                Console.WriteLine(" 준비!");
            }

            // start count
            Console.Write("3 ");
            Thread.Sleep(1000);
            Console.Write("2 ");
            Thread.Sleep(1000);
            Console.Write("1 ");
            Thread.Sleep(1000);

            Console.Write("GO! ");
            Console.WriteLine(" ");

            // race
            float furthestDistance = 0f;
            for( ; ; )
            {

            }

        }
    }
}
