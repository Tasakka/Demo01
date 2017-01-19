using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = Console.Write("Kuinka vanha olet ? > ");
            if (age < 18) {
                Console.WriteLine("Alaikäinen");
            }
            else if (age > 18 || age < 65)
            {
                Console.WriteLine("Aikuinen");
            }
            else if (age > 65)
            {
                Console.WriteLine("Seniori");
            }
        }
    }
}
