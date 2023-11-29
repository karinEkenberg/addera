using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Var god skriv in en siffra:");
            string dinSiffra = Console.ReadLine();
            int nr1 = Convert.ToInt32(dinSiffra);
            Console.WriteLine("Var god skriv ett nr till:");
            string dinAndraSiffra = Console.ReadLine();
            int nr2 = Convert.ToInt32(dinAndraSiffra);
            int sum = nr1 + nr2;
            Console.WriteLine("Dina siffror blir tillsammans " + sum + ".");
        }
    }
}
