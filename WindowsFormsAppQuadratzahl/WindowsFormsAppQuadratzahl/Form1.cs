using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppQuadratzahl
{
    public partial class Quadratzahl : Form
    {
        public Quadratzahl()
        {
            InitializeComponent();
            labelUeberschrift.Text = "Wasser";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void berechnen_Click(object sender, EventArgs e)
        {
            int ergebnis;

            ergebnis = Convert.ToInt32(textboxEingabe.Text) * Convert.ToInt32(textboxEingabe.Text);

            textboxAusgabe.Text = Convert.ToString(ergebnis);
        }
    }
}
