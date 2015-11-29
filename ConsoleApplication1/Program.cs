using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApplication1;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Character titan = new Titan(500,300,15,30,0);
            Character titan1 = new Titan(500, 300, 15, 30,0);
            Character sisadmin = new siskadmin(250, 500, 5, 20, 0);
            Character sisadmin1 = new siskadmin(250, 500, 5, 20, 0);
            Character invoker = new invoker(350, 10, 500, 20,0);
            Character invoker1 = new invoker(350, 700, 10, 50, 0);
            Character Ninjos = new Ninjos(300, 400, 3, 100, 0.1);
            Character Ninjos1 = new Ninjos(300, 400, 3, 100 , 0.1);
            Character cheater = new cheater(99999, 99999, 99999, 9999999, 9999999999);
            Character cheater1 = new cheater(99999, 99999, 99999, 9999999, 9999999999);
            Console.ReadLine();
        }
    }
}
