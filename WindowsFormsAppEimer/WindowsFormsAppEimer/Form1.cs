using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEimer
{
    public partial class Form : System.Windows.Forms.Form
    {
        Eimer eimer;
        int height;
        int aktuell;
        public Form()
        {
            InitializeComponent();
            height = panelVoll.Height;
            aktuell = height - panelLeer.Height;
            eimer = new Eimer(height);
            aktualisieren();
        }

        private void buttonLeeren_Click(object sender, EventArgs e)
        {
            aktuell = 0;
            panelLeer.Height = height;
            aktualisieren();
        }

        private void buttonHinzufügen_Click(object sender, EventArgs e)
        {
            if(panelLeer.Height > 0)
            {
                aktuell += Convert.ToInt32(textBoxHinzufügen.Text);
                panelLeer.Height -= Convert.ToInt32(textBoxHinzufügen.Text);
                aktualisieren();
            }
            else
            {
                eimervoll();
            }
        }

        private void eimervoll()
        {
            MessageBox.Show("Eimer ist bereits voll!");
        }

        private void aktualisieren()
        {
            textBoxMenge.Text = aktuell.ToString();
        }
    }
}
