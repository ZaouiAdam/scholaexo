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
            Add(A, B);
            Sous(A, B);
        }

        /// <summary>
        /// Fonctions d'addition
        /// </summary>
        /// <param name="val1">A</param>
        /// <param name="val2">B</param>
        static void Add(int val1, int val2)
        {
            string Addition = "addition";
            Console.WriteLine("L'"+Addition+" de " + val1 + " et " + val2 + " vaut " + (val1 + val2));
            Console.ReadLine();
        }

        /// <summary>
        /// Fonctions de soustraction
        /// </summary>
        /// <param name="val1">A</param>
        /// <param name="val2">B</param>
        static void Sous(int val1, int val2)
        {
            string Soustraction = "soustraction";
            Console.WriteLine("La "+Soustraction+" de " + val1 + " et " + val2 + " vaut " + (val1 - val2));
            Console.ReadLine();
        }
    }
}
