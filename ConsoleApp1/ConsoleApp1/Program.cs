using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kW eingeben: ");
            double eingabe = Convert.ToDouble(Console.ReadLine());

            eingabe = eingabe * 1.36;

            Console.WriteLine("PS: " + eingabe);
            Console.ReadKey();
        }
    }
}
