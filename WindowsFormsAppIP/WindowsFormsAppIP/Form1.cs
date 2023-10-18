using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsAppIP
{
    public partial class Form1 : Form
    {
        Verwaltung v;
        List<String> list;
        public Form1()
        {
            InitializeComponent();
            v = new Verwaltung();
            list = new List<String>();
            read();
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            v.Send(list);
            lstOK.DataSource = null;
            lstNichtOK.DataSource = null;
            lstOK.DataSource = v.ListOK;
            lstNichtOK.DataSource = v.ListNOT;
        }

        private void read()
        {
            StreamReader reader = new StreamReader("IPAdressen.txt",Encoding.UTF8);
            while(reader.EndOfStream != true)
            {
                string z = reader.ReadLine();
                list.Add(z);
            }
            reader.Close();
            lstIP.DataSource = null;
            lstIP.DataSource = list;
        }
    }
}
