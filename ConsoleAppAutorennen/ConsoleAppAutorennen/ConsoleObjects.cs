using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppAutorennen
{
    public class ConsoleObjects
    {
        private List<IConsoleObjects> listObjects = null;

        public ConsoleObjects()
        {
            listObjects = new List<IConsoleObjects>();
        }

        public void DisplayAll()
        {
            foreach (IConsoleObjects obj in listObjects)
            {
                obj.Display();
            }
        }

        public void AddObject(IConsoleObjects obj)
        {
            listObjects.Add(obj);           
        }
        public void DriveAll()
        {
            Object lockObject = new Object();
            foreach(IConsoleObjects obj in listObjects)
            {
                Thread thread = new Thread(new ParameterizedThreadStart(obj.Drive));
                thread.Start(lockObject);
            }
        }
    }
}
