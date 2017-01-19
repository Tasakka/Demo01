using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht5
{
    class Program
    {
        static void Main(string[] args)
        {
            int time;
            int hours;
            int minutes;
            int seconds;
            Console.Write("Anna sekunnit > ");
            time = int.Parse(Console.ReadLine());
            hours = time / 3600;
            minutes = (time % 3600) / 60;
            seconds = time % 60;
            Console.WriteLine("tunteja: " + hours + " minuutteja: " + minutes + " sekunteja: " + seconds);
        }
    }
}
