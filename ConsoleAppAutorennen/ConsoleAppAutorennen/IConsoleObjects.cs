using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAutorennen
{
    public interface IConsoleObjects
    {
        void Display();
        void Drive(Object lockObject);
        void Stop();
    }
}
