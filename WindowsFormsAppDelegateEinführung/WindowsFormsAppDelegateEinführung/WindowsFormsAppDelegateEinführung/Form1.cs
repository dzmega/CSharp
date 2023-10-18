using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDelegateEinführung
{
    public partial class Form1 : Form
    {
        Vorschlaege vorschlaege;
        public Form1()
        {
            InitializeComponent();
            vorschlaege = new Vorschlaege();
            vorschlaege.OnMaxVorschlage += fehlermeldung;
            aktualisieren();
        }

        private void fehlermeldung(string text)
        {
            MessageBox.Show(text);
            textBoxVorschlag.BackColor = Color.Red;
        }

        private void buttonAufnehmen_Click(object sender, EventArgs e)
        {
            vorschlaege.VorschlagAufnehmen(textBoxVorschlag.Text);
            aktualisieren();
        }

        private void aktualisieren()
        {
            listBoxVorschlag.DataSource = null;
            listBoxVorschlag.DataSource = vorschlaege.Liste;
        }

        private void buttonAlleLoeschen_Click(object sender, EventArgs e)
        {
            vorschlaege.AlleLoeschen();
            textBoxVorschlag.Text = "";
            textBoxVorschlag.BackColor = SystemColors.Window;
            aktualisieren();
        }
    }
}
