using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ViewModel
{
    public class VMMainWindow
    {
        private ObservableCollection<VMPerson> personen;
        private UserCommand command;

        public VMMainWindow()
        {
            personen = new ObservableCollection<VMPerson>();
            personen.Add(new VMPerson("Calvin", "Quest", 23));
            personen.Add(new VMPerson("Nils", "Zahn", 22));
            personen.Add(new VMPerson("Lukas", "Knorr", 19));
            command = new UserCommand(new Action<object>(VMMVGeburtstag));
        }

        private void VMMVGeburtstag(object obj)
        {
            ((VMPerson)obj).Geburtstag();
        }

        public ObservableCollection<VMPerson> Personen { get => personen; set => personen = value; }
        public UserCommand Command { get => command; set => command = value; }
    }
}
