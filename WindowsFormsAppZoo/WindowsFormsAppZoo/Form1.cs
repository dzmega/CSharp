using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppZoo
{
    public partial class Form1 : Form
    {
        Tierverwaltung tierverwaltung;
        public Form1()
        {
            InitializeComponent();
            tierverwaltung = new Tierverwaltung();
            listBoxTier.DataSource = tierverwaltung.ListTier;
        }

        private void listBoxTier_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonFüttern_Click(object sender, EventArgs e)
        {
            Tier clicked = (Tier)listBoxTier.SelectedItem;
            if (listBoxTier.SelectedItem != null)
            {
                clicked.füttern();
                listBoxTier.DataSource = null;
                listBoxTier.DataSource = tierverwaltung.ListTier;
            }
        }
    }
}
