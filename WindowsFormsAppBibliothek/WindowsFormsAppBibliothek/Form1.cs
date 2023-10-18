using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppBibliothek
{
    public partial class labelVerfügbarkeit : Form
    {
        private List<Buch> listBuecher;
        
        public labelVerfügbarkeit()
        {
            InitializeComponent();
            listBuecher = new List<Buch>();
            listBuecher.Add(new Buch("Die Säulen der Erde","Alexander Magel"));
            listBuecher.Add(new Buch("Python für Anfänger","Patrick Henning"));
            comboBoxBuecher.DataSource = listBuecher;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buch auswahl = ((Buch)comboBoxBuecher.SelectedItem);
            if (auswahl.Ausgeliehen == false)
            {
                labelAngabe.Text = "verfügbar";
                buttonZurückgeben.Enabled = false;
                buttonAusleihen.Enabled = true;
            }
            else
            {
                labelAngabe.Text = "vergeben";
                buttonZurückgeben.Enabled = true;
                buttonAusleihen.Enabled = false;
            }
        }

        private void buttonAusleihen_Click(object sender, EventArgs e)
        {
            Buch auswahl = (Buch)comboBoxBuecher.SelectedItem;
            auswahl.Ausleihen();
            if (auswahl.Ausgeliehen == false)
            {
                labelAngabe.Text = "verfügbar";
                buttonZurückgeben.Enabled = false;
                buttonAusleihen.Enabled = true;
            }
            else
            {
                labelAngabe.Text = "vergeben";
                buttonZurückgeben.Enabled = true;
                buttonAusleihen.Enabled = false;
            }
        }

        private void buttonZurückgeben_Click(object sender, EventArgs e)
        {
            Buch auswahl = (Buch)comboBoxBuecher.SelectedItem;
            auswahl.Zurückgeben();
            if (auswahl.Ausgeliehen == false)
            {
                labelAngabe.Text = "verfügbar";
                buttonZurückgeben.Enabled = false;
                buttonAusleihen.Enabled = true;
            }
            else
            {
                labelAngabe.Text = "vergeben";
                buttonZurückgeben.Enabled = true;
                buttonAusleihen.Enabled = false;
            }
        }
    }
}
