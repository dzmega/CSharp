using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppHaustiermanager
{
    public partial class Form1 : Form
    {
        List<Tier> tierlist;
        public Form1()
        {
            InitializeComponent();
            tierlist = new List<Tier>();
        }

        private void buttonFüttern_Click(object sender, EventArgs e)
        {
            Tier clicked = (Tier)comboBoxTiere.SelectedItem;
            clicked.Füttern();
            aktualisieren();
        }

        private void buttonImpfen_Click(object sender, EventArgs e)
        {
            Tier clicked = (Tier)comboBoxTiere.SelectedItem;
            clicked.Impfen();
            aktualisieren();
        }

        private void buttonAufnehmen_Click(object sender, EventArgs e)
        {
            if(radioButtonHund.Checked == true)
            {
                Tier tier = new Hund(textBoxName.Text, Convert.ToDouble(textBoxGewicht.Text), Convert.ToInt32(textBoxHundeStNr.Text), 0);
                tierlist.Add(tier);
            }
            else if(radioButtonKatze.Checked == true)
            {
                Tier tier = new Katze(textBoxName.Text, Convert.ToDouble(textBoxGewicht.Text), 0);
                tierlist.Add(tier);
            }
            else
            {
                Tier tier = new Rassekatze(textBoxName.Text, Convert.ToDouble(textBoxGewicht.Text), 0);
                tierlist.Add(tier);
            }
            aktualisieren();
        }

        private void aktualisieren()
        {
            listBoxTiere.DataSource = null;
            listBoxTiere.DataSource = tierlist;
            comboBoxTiere.DataSource = null;
            comboBoxTiere.DataSource = tierlist;
            textBoxName.Text = "";
            textBoxGewicht.Text = "";
            textBoxHundeStNr.Text = "";
            textBoxName.Focus();
        }

        private void radioButtonKatze_CheckedChanged(object sender, EventArgs e)
        {
            textBoxHundeStNr.Enabled = false;
        }

        private void radioButtonRassekatze_CheckedChanged(object sender, EventArgs e)
        {
            textBoxHundeStNr.Enabled = false;
        }

        private void radioButtonHund_CheckedChanged(object sender, EventArgs e)
        {
            textBoxHundeStNr.Enabled = true;
        }
    }
}
