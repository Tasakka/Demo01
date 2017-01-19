using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.Write("Anna vuosi > ");
            year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 || year % 400 == 0)
            {
                Console.WriteLine("Vuosi on karkausvuosi.");
            }
            /*else if (year % 400 == 0)
            {
                Console.WriteLine("Vuosi on karkausvuosi.");
            }*/
            else
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi.");
            }
        }
    }
}
