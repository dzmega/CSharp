using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAutos
{
    public partial class Form1 : Form
    {
        Autoverwaltung autoverwaltung;
        public Form1()
        {
            InitializeComponent();
            autoverwaltung = new Autoverwaltung();
            listBoxAutos.DataSource = autoverwaltung.ListAuto;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void autoErzeugen_Click(object sender, EventArgs e)
        {
            autoverwaltung.AutoErzeugen(textBoxKennzeichen.Text, Convert.ToDouble(textBoxMenge.Text),Convert.ToInt32(textBoxKM.Text), Convert.ToDouble(textBoxVerbrauch.Text));
            listBoxAutos.DataSource = null;
            listBoxAutos.DataSource = autoverwaltung.ListAuto;
        }

        private void listBoxAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Auto clicked = (Auto)listBoxAutos.SelectedItem;
            if(listBoxAutos.SelectedItem != null)
            {
                textBoxKennzeichen.Text = clicked.Kennzeichen;
                string af = Convert.ToString(clicked.AktuelleFuellung);
                textBoxMenge.Text = af;
                string v = Convert.ToString(clicked.Verbrauch);
                textBoxVerbrauch.Text = v;
                string k = Convert.ToString(clicked.Kilometerstand);
                textBoxKM.Text = k;
            }
        }
    }
}
