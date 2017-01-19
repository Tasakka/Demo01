using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance;
            double consumption = 7.02;
            double price = 1.595;
            Console.Write("Anna matka > ");
            distance = int.Parse(Console.ReadLine());
            double total_consumption = (distance / 100) * consumption;
            double cost = price * total_consumption;
            Console.WriteLine("Bensaa kuluu: " + total_consumption + ", kustannus: " + cost); 
        }
    }
}
