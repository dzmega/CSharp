using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppRakete
{
    public interface IConsoleObjects
    {
        void Display();
        void MoveUp(object lockobject);
        void Stop();
    }
}
