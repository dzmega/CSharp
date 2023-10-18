using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEvent
{
    public partial class Form1 : Form
    {
        FrageVerwaltung fVerwaltung;
        Frage frage;
        public Form1()
        {
            InitializeComponent();
            fVerwaltung = new FrageVerwaltung();
            fVerwaltung.Lesen();
            frage = new Frage();
            aktualisierenFragen();
            
        }

        private void buttonAuswerten_Click(object sender, EventArgs e)
        {
            frage.Loesen();
        }

        private void aktualisierenFragen()
        {
            comboBoxFragen.DataSource = null;
            comboBoxFragen.DataSource = fVerwaltung.Fragen;
        }

        private void aktualisierenAntworten()
        {
            listBoxAuswahl.DataSource = null;
            listBoxAuswahl.DataSource = ((Frage)comboBoxFragen.SelectedItem).Antworten;
        }

        private void comboBoxFragen_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktualisierenAntworten();
        }

        public void Message()
        {
            MessageBox.Show("Antwort wurde abgegeben!");
        }
    }
}