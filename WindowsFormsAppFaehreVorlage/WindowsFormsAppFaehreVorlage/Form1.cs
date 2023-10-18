using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppFaehreVorlage
{
    public partial class FormFaehre : Form
    {
        private List<Fahrzeug> autoDeck;
        public FormFaehre()
        {
            InitializeComponent();
            autoDeck = new List<Fahrzeug>();
        }

        private void groupBoxFähre_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxKennzeichen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
