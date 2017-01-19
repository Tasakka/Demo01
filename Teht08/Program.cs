using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht08
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("Give three whole numbers > ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2);
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine(num3);
            }
        }
    }
}
