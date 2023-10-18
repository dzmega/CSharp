using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleAppThreads
{
    public class Program
    {
        public static Thread thread1 = null;
        public static Thread thread2 = null;
        private static Object thisLock = new Object();

        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(Aufgabe1);
            thread1 = new Thread(ts);
            thread2 = new Thread(new ThreadStart(Aufgabe2));

            thread1.Start();
            thread2.Start();
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hauptthread");
            }

            Console.ReadKey();
        }

        public static void Aufgabe1()
        {
            for(int i = 0; i < 10; i++)
            {
                lock(thisLock)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ich bin Aufgabe1");
                }
            }
            
        }

        public static void Aufgabe2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ich bin Aufgabe2");
            }
        }
    }
}
