using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht09
{
    class Program
    {
        static void Main(string[] args)
        {
            // huonompi tapa!!
            /*int luku = -1;
            while (luku != 0)
            {
                Console.Write("Anna luku > ");
                luku = int.Parse(Console.ReadLine());
            }*/
            int luku;
            int sum = 0;
            do
            {
                Console.Write("Anna luku > ");
                luku = int.Parse(Console.ReadLine());
                sum += luku;
            } while (luku != 0);
            Console.WriteLine("Kaikkien lukujen summa: " + sum);
        }
    }
}
