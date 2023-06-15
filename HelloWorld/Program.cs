using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            NameAge("Emran",28);
            Console.ReadLine();
        }

        //method call
        static void NameAge(string Name,int Age)
        {
            Console.WriteLine("Hello "+Name+" You Are "+Age);
        }
    }
}
