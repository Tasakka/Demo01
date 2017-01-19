using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask points
            int points;
            Console.Write("How many points did you get? ");
            points = int.Parse(Console.ReadLine());
            switch (points)
            {
                case 0: Console.WriteLine("0"); break;
                case 1: Console.WriteLine("0"); break;
                case 2: Console.WriteLine("1"); break;
                case 3: Console.WriteLine("1"); break;
                case 4: Console.WriteLine("2"); break;
                case 5: Console.WriteLine("2"); break;
                case 6: Console.WriteLine("3"); break;
                case 7: Console.WriteLine("3"); break;
                case 8: Console.WriteLine("4"); break;
                case 9: Console.WriteLine("4"); break;
                case 10: Console.WriteLine("5"); break;
                case 11: Console.WriteLine("5"); break;
                case 12: Console.WriteLine("5"); break;
            }
        }
    }
}
