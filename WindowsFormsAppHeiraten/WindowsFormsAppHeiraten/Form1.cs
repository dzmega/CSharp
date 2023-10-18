using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppHeiraten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonErschaffen_Click(object sender, EventArgs e)
        {
            Mensch mensch = new Mensch(textBoxVorname.Text, textBoxNachname.Text, Convert.ToInt32(textBoxAlter.Text), textBoxFamilienstand.Text);
            mensch.OnSchonVerheiratet += NichtHeiraten;
            listBoxMenschen.Items.Add(mensch);
        }

        private void buttonHeiraten_Click(object sender, EventArgs e)
        {
            Mensch mensch = (Mensch)listBoxMenschen.SelectedItem;
            mensch.Heiraten(textBoxNewName.Text);
        }

        public void NichtHeiraten()
        {
            MessageBox.Show("Du darfst nicht mehr heiraten!");
        }
    }
}
