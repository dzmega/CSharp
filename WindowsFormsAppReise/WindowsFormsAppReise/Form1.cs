using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace WindowsFormsAppReise
{
    public partial class Form1 : Form
    {
        Reise reise;
        private List<Reise> reiseListe;
        public Form1()
        {
            InitializeComponent();
            reiseListe = new List<Reise>();
            reiseListe.Add(new Reise("Hamburg", 1250, Convert.ToDateTime("1.10.2020"), Convert.ToDateTime("10.10.2020"), 5));
            //reise = new Reise();
            ReiseLaden();
            aktualisieren();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAufnehmen_Click(object sender, EventArgs e)
        {
            Teilnehmer teilnehmer = new Teilnehmer(textBoxEmail.Text,textBoxNachname.Text,textBoxVorname.Text);
            reise.TeilnehmerAufnehmen(teilnehmer);
            aktualisieren();
        }

        private void buttonEntfernen_Click(object sender, EventArgs e)
        {
            reise.TeilnehmerLöschen((Teilnehmer)listBoxTeilnehmer.SelectedItem);
            aktualisieren();
        }

        private void listBoxTeilnehmer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxReise_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonReiseAufnehmen_Click(object sender, EventArgs e)
        {
            Reise reise = new Reise(textBoxZiel.Text, Convert.ToDecimal(textBoxPreis.Text), Convert.ToDateTime(textBoxVon.Text), Convert.ToDateTime(textBoxBis.Text), Convert.ToInt32(textBoxMaxTN.Text));
            ReiseAufnehmen(reise);
            aktualisieren();
        }

        private void aktualisieren()
        {
            listBoxReise.DataSource = null;
            listBoxReise.DataSource = reiseListe;
            listBoxTeilnehmer.DataSource = null;
            listBoxTeilnehmer.DataSource = reiseListe[0].TeilnehmerListe;
        }

        public void ReiseAufnehmen(Reise reise)
        {
            reiseListe.Add(reise);
        }
        public void ReiseLaden()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Reise>));
            TextReader reader = new StreamReader("Reisen.xml");
            reiseListe = (List<Reise>)serializer.Deserialize(reader);
            reader.Close();
        }
    }
}
