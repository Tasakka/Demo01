using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask numbers
            int number1, number2, number3;
            Console.Write("Give 3 numbers > ");
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            number3 = int.Parse(Console.ReadLine());
            int sum = number1 + number2 + number3;
            Console.WriteLine(sum);
            Console.WriteLine(sum / 3);
        }
    }
}
