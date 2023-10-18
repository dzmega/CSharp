using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppWohnhaus
{
    public class Wohnhaus
    {
        private int count = 0;
        private string[] wohnung = new string[6];


        public Wohnhaus()
        {
            for (int i = 0; i < 6; i++)
            {
                wohnung[i] = "none";
            }
        }

        public int Count { get => count; set => count = value; }

        public bool Ausziehen(string mieter)
        {
            if(count > 0)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (wohnung[i] == mieter)
                    {
                        wohnung[i] = "none";
                        count--;
                    }
                }
            }
            return true;
        }
        public bool Einziehen(string mieter)
        {
            if(count < 6)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (wohnung[i] == mieter)
                    {
                        return false;
                    }
                    else
                    {
                        if (wohnung[i] == "none")
                        {
                            wohnung[i] = mieter;
                            count++;
                            i = 100;
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
