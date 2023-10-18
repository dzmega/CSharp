using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleAppRakete
{
    public class ConsoleObjects
    {
        private List<IConsoleObjects> listObjects = null;
        public Object lockObject = new Object();
        public ConsoleObjects()
        {
            listObjects = new List<IConsoleObjects>();
        }
        public void DisplayAll()
        {
            foreach(IConsoleObjects co in listObjects)
            {
                co.Display();
            }
        }
        public void AddObject(IConsoleObjects consobject)
        {
            listObjects.Add(consobject);
        }
        public void MoveAllUp()
        {
            object lockObject = new object();
            foreach(IConsoleObjects ic in listObjects)
            {
                ParameterizedThreadStart ts = new ParameterizedThreadStart(ic.MoveUp);
                Thread thread = new Thread(ts);
                thread.Start(lockObject);
            }
        }
    }
}
