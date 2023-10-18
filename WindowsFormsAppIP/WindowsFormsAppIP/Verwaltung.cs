using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsAppIP
{
    public class Verwaltung
    {
        List<String> listOK;
        List<String> listNOT;

        public Verwaltung()
        {
            ListOK = new List<String>();
            ListNOT = new List<String>();
        }

        public List<string> ListOK { get => listOK; set => listOK = value; }
        public List<string> ListNOT { get => listNOT; set => listNOT = value; }

        public void Send(List<String> list)
        {
            Ping Sender = new Ping();

            foreach(String str in list)
            {
                PingReply Result = Sender.Send(str);
                if (Result.Status == IPStatus.Success)
                {
                    ListOK.Add(str);
                }
                else
                {
                    ListNOT.Add(str);
                }
            }
            
        }
    }
}
