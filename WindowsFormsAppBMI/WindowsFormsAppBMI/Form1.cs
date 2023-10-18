using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppBMI
{
    public partial class BMIfürMänner : Form
    {
        public BMIfürMänner()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxGewicht_TextChanged(object sender, EventArgs e)
        {

        }

        private void berechnenButton_Click(object sender, EventArgs e)
        {
            double bmi;

            bmi = Convert.ToDouble(textBoxGewicht.Text) / (Convert.ToDouble(textBoxGröße.Text) * Convert.ToDouble(textBoxGröße.Text));
            textBoxBMI.Text = Convert.ToString(bmi);

            if (bmi < 20)
            {
                textBoxKlassifikation.Text = "Untergewichtig";
                pictureBoxBild.Image = Image.FromFile(@"H:\C#\Bilder\Döner.jpg");
            }
            if(bmi >= 20 && bmi <= 25)
            {
                textBoxKlassifikation.Text = "Normalgewicht";
                pictureBoxBild.Image = Image.FromFile(@"H:\C#\Bilder\Steak.jpg");
            }
            if(bmi > 25)
            {
                textBoxKlassifikation.Text = "Übergewichtig";
                MessageBox.Show("Bitte achten Sie auf ihren BMI");
                pictureBoxBild.Image = Image.FromFile(@"H:\C#\Bilder\Salatteller.jpg");
            }
        }
    }
}
