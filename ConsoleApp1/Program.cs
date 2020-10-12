using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 1;
            int B = 2;
            string Addition = "addition";
            string Soustraction = "soustraction";
            Console.WriteLine("L'"+Addition+" de "+A+" et "+B+" vaut "+ (A+B));
            Console.WriteLine("La "+Soustraction+" de "+A+" et "+B+" vaut "+(A-B));
            Console.ReadLine();
        }
    }
}
