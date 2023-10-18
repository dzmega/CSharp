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
        Faehre faehre;
        public FormFaehre()
        {
            InitializeComponent();
            faehre = new Faehre(100, "Teutonia");
           


            textBoxBelegteLaenge.Text = faehre.BelegteLaenge.ToString();
            textBoxName.Text = faehre.Name;
            textBoxLänge.Text = faehre.MaxLaenge.ToString();
            faehre.PreisProPerson = 5;
            faehre.PreisProTonne = 10;
            faehre.GrundPreisLKW = 100;
            faehre.GrundPreisPKW = 20;

            faehre.OnZuLang += fehlermeldung;

        }


        private void buttonPKWaufnehmen_Click(object sender, EventArgs e)
        {
            PKW pkw = new PKW(textBoxKennzeichen.Text, Convert.ToDouble(textBoxFahrzeugLänge.Text), Convert.ToInt32(textBoxLeergewicht.Text));
            pkw.Personenanzahl = Convert.ToInt32(textBoxPersonenanzahl.Text);

            textBoxPreisAuto.Text= faehre.FahrzeugAufnehmen(pkw).ToString();

            setzen(Convert.ToDecimal(textBoxPreisAuto.Text));
        }

        private void fehlermeldung()
        {
            MessageBox.Show("Maximale Länge bereits erreicht!");
        }

        private void setzen(decimal aufgenommen)
        {

                listBoxaufgenommeneFahrzeuge.DataSource = null;
                listBoxaufgenommeneFahrzeuge.DataSource = faehre.AutoDeck;
                textBoxBelegteLaenge.Text = faehre.BelegteLaenge.ToString();
        }

        private void buttonLKWaufnehmen_Click(object sender, EventArgs e)
        {
            LKW lkw = new LKW(textBoxKennzeichen.Text, Convert.ToDouble(textBoxFahrzeugLänge.Text), Convert.ToInt32(textBoxLeergewicht.Text));
            lkw.Gesamtgewicht = Convert.ToInt32(textBoxGesamtgewicht.Text);
            textBoxLKWPreis.Text = faehre.FahrzeugAufnehmen(lkw).ToString();
            setzen(Convert.ToDecimal(textBoxLKWPreis.Text));
        }
    }
}
