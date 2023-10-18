using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppHaustiermanager
{
    public class Rassekatze:Tier
    {
        public Rassekatze(string name, double gewicht, int impfungen):base()
        {
            Name = name;
            Gewicht = gewicht;
            Impfungen = impfungen;
        }

        public override void Füttern()
        {
            Gewicht = Math.Round((Gewicht * 1.03),2); ;
        }

        public override void Impfen()
        {
            if(Impfungen < 3)
            {
                Impfungen++;
            }
            else
            {
                MessageBox.Show("Impfung ist nicht möglich!");
            }
        }
    }
}
