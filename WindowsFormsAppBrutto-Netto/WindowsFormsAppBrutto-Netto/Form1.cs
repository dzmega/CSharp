using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppBrutto_Netto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bruttoButton_Click(object sender, EventArgs e)
        {
            double ergebnis;
            if(textBoxNetto.Text == "")
            {
                MessageBox.Show("Bitte einen Wert eingeben!");
            }
            else
            {
                if (highRadioButton.Checked == false && lowRadioButton.Checked == false)
                {
                    MessageBox.Show("Bitte einen Steuerwert anklicken!");
                }
                else
                {
                    if (lowRadioButton.Checked == true)
                    {
                        ergebnis = Convert.ToDouble(textBoxNetto.Text) * 1.07;
                        textBoxBrutto.Text = Convert.ToString(Math.Round(ergebnis, 2));
                    }
                    else
                    {
                        ergebnis = Convert.ToDouble(textBoxNetto.Text) * 1.19;
                        textBoxBrutto.Text = Convert.ToString(Math.Round(ergebnis, 2));
                    }
                }
            }   
        }

        private void nettoButton_Click(object sender, EventArgs e)
        {
            double ergebnis;

            if (textBoxNetto.Text == "")
            {
                MessageBox.Show("Bitte einen Wert eingeben!");
            }
            else
            {
                if (highRadioButton.Checked == false && lowRadioButton.Checked == false)
                {
                    MessageBox.Show("Bitte einen Steuerwert anklicken!");
                }
                else
                {
                    if (lowRadioButton.Checked == true)
                    {
                        ergebnis = Convert.ToDouble(textBoxBrutto.Text) / 1.07;
                        textBoxNetto.Text = Convert.ToString(Math.Round(ergebnis, 2));
                    }
                    else
                    {
                        ergebnis = Convert.ToDouble(textBoxBrutto.Text) / 1.19;
                        textBoxNetto.Text = Convert.ToString(Math.Round(ergebnis, 2));
                    }
                }
            }
        }
    }
}
