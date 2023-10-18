using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCollection
{
    public partial class listBoxSchüler : Form
    {
        private List<Schüler> listSchüler;
        public listBoxSchüler()
        {
            InitializeComponent();
            listSchüler = new List<Schüler>();
            Schüler schüler = new Schüler("Daniel", Convert.ToDateTime("02.03.1999"), "Dittelbrunn");
            listSchüler.Add(schüler);
            listSchüler.Add(new Schüler("Rena", Convert.ToDateTime("22.06.1996"), "Sennfeld"));
            listBoxSchueler.DataSource = listSchüler;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void schülerAufnehmen_Click(object sender, EventArgs e)
        {
            listSchüler.Add(new Schüler(textBoxName.Text, textBoxGeburtstag.Text, textBoxWohnort.Text));
            listBoxSchueler.DataSource = null;
            listBoxSchueler.DataSource = listSchüler;
        }

        private void schülerEntlassen_Click(object sender, EventArgs e)
        {
            Schüler loesch = (Schüler)listBoxSchueler.SelectedItem;
            listSchüler.Remove(loesch);
            listBoxSchueler.DataSource = null;
            listBoxSchueler.DataSource = listSchüler;
        }

        private void listBoxSchueler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Schüler clicked = (Schüler)listBoxSchueler.SelectedItem;
            textBoxName.Text = clicked.Name;
            textBoxGeburtstag.Text = clicked.Geburtstag;
            textBoxWohnort.Text = clicked.Wohnort;
        }
    }
}
