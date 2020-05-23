using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {

            loadLog();
            
        }
        
        private void loadLog()
        {
            try
            {
                string[] lines = File.ReadAllLines("log.txt");
                foreach (string s in lines)
                {
                    if (s != "")
                        Log(s);
                }
            }
            catch
            {
              
            }
        }
        private void Log(string s)
        {
            string[] arrListStr = s.Split('+');

            ListViewItem x = new ListViewItem(arrListStr[0]);
            ListViewItem.ListViewSubItem y = new ListViewItem.ListViewSubItem(x, arrListStr[1]);
            ListViewItem.ListViewSubItem z = new ListViewItem.ListViewSubItem(x, arrListStr[2]);
            ListViewItem.ListViewSubItem t = new ListViewItem.ListViewSubItem(x, arrListStr[3]);

            x.SubItems.Add(y);
            x.SubItems.Add(z);
            x.SubItems.Add(t);
            log_tb.Items.Insert(0, x);
        }
        //delete history
        private void button1_Click(object sender, EventArgs e)
        {
            File.Delete("log.txt");
            log_tb.Items.Clear();
        }
    }
}
