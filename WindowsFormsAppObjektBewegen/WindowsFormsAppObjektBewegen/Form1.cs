using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppObjektBewegen
{
    public partial class Form1 : Form
    {
        private Item dennis = new Item(10);
        private Item leon = new Item(30);
        public Form1()
        {
            InitializeComponent();
            dennis.MyControl = this.labelDennis;
            leon.MyControl = this.labelLeon;
            leon.OnMaxHoehe += zielLeon;
            dennis.OnMaxHoehe += zielDennis;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void zielLeon()
        {
            BackColor = Color.Magenta;
        }
        private void zielDennis()
        {
            BackColor = Color.Yellow;
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            leon.MoveUp();
            dennis.MoveUp();
        }
    }
}
