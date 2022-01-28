using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ducks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck[] ducks = new Duck[]
            {
                new MallardDuck(),
                new RedHeadDuck(),
                new RubberDuck(),
                new DecoyDuck()
            };

            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck.Swim());
                Console.WriteLine(duck.Display());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}