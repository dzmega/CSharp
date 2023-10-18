using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEnum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //comboBoxFarbe.Items.Add(EnumFarbe.pink);
            //comboBoxFarbe.Items.Add(EnumFarbe.lila);
            //comboBoxFarbe.Items.Add(EnumFarbe.grün);
            //comboBoxFarbe.Items.Add(EnumFarbe.blau);
            comboBoxFarbe.DataSource = Enum.GetValues(typeof(EnumFarbe));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            if((EnumFarbe)comboBoxFarbe.SelectedItem == EnumFarbe.lila)
            {
                this.BackColor = Color.Purple;
            }
            if ((EnumFarbe)comboBoxFarbe.SelectedItem == EnumFarbe.pink)
            {
                this.BackColor = Color.Pink;
            }
            if ((EnumFarbe)comboBoxFarbe.SelectedItem == EnumFarbe.grün)
            {
                this.BackColor = Color.Green;
            }
            if ((EnumFarbe)comboBoxFarbe.SelectedItem == EnumFarbe.blau)
            {
                this.BackColor = Color.Blue;
            }
            if ((EnumFarbe)comboBoxFarbe.SelectedItem == EnumFarbe.grau)
            {
                this.BackColor = Color.Gray;
            }
        }
    }
}
