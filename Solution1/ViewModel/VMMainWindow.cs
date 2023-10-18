using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class VMMainWindow
    {
        private int km;
        private VMAuto vmAuto;
        private UserCommand userCommand;

        public VMMainWindow()
        {
            vmAuto =  new VMAuto("OCH DZ 11");
            km = 0;
            userCommand = new UserCommand(new Action<object>(VMFahren));
        }

        private void VMFahren(object obj)
        {
            VMAuto akt = (VMAuto)obj;
            akt.Fahren(Km);
        }

        public int Km { get => km; set => km = value; }
        public VMAuto VmAuto { get => vmAuto; set => vmAuto = value; }
        public UserCommand UserCommand { get => userCommand; set => userCommand = value; }
    }
}
