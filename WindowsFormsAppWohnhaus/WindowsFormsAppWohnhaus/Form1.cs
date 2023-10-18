using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppWohnhaus
{
    public partial class Form1 : Form
    {
        Wohnhaus wohnhaus = new Wohnhaus();
 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            bool wert = wohnhaus.Einziehen(name);
            int count = wohnhaus.Count;
            if (wert == true)
            {
                labelAusgabe.Text = "Glückwunsch zur neuen Wohnung";
                labelWohnung.Text = "Sie besitzen die " + count + " Wohnung";
            }
            else
            {
                labelAusgabe.Text = "Einzug nicht möglich";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAusziehen_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            bool wert = wohnhaus.Ausziehen(name);
            int count = wohnhaus.Count;
            if (wert == true)
            {
                labelAusgabe.Text = "Auszug erfolgreich";
                count++;
                labelWohnung.Text = "Besitzer von der " + count + ". Wohnung ist ausgezogen";
                count--;
            }
            else
            {
                labelAusgabe.Text = "Auszug nicht möglich";
            }
        }
    }
}
