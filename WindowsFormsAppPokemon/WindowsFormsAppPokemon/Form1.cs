using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPokemon
{
    public partial class Form1 : Form
    {
        string[] array;
        public Form1()
        {
            array = new string[4] { @"Bilder\Pummeluff.png", @"Bilder\Karnimani.png", @"Bilder\Felilou.png", @"Bilder\Pikachu.png" };
            InitializeComponent();
            comboBoxPokemon.DataSource = Enum.GetValues(typeof(EnumPokemon));
          
            comboBoxPokemon.SelectedIndex = 0;
        }

        private void comboBoxPokemon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(comboBoxPokemon.SelectedIndex);

            pictureBox1.Image = Image.FromFile(array[index]);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
