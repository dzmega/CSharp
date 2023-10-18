using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie einen Satz ein: ");
            string satz = Console.ReadLine();
            satz = satz.ToUpper();
            int right = 0;

            satz = satz.Replace(" ", "");
            int length = satz.Length;
            length--;
            Console.WriteLine(satz);
            for (int i = 0; i < length; i++)
            {
                if(satz[i] == satz[length - i])
                {
                    right++;
                }                
            }

            if(right == length)
            {
                Console.WriteLine("Es ist ein Palindrom");
            }
            else
            {
                Console.WriteLine("Es ist kein Palindrom");
            }
            Console.ReadKey();
        }
    }
}
