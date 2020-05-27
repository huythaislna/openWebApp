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
                string[] log_list = File.ReadAllLines("log.txt");
                foreach (string log in log_list)
                {
                    if (log != "")
                        Log(log);
                }
            }
            catch
            {
              
            }
        }
        private void Log(string log)
        {
            string[] log_fields = log.Split('|');

            ListViewItem new_log_row = new ListViewItem(log_fields[0]);
            ListViewItem.ListViewSubItem status = new ListViewItem.ListViewSubItem(new_log_row, log_fields[1]);
            ListViewItem.ListViewSubItem address = new ListViewItem.ListViewSubItem(new_log_row, log_fields[2]);
            ListViewItem.ListViewSubItem time = new ListViewItem.ListViewSubItem(new_log_row, log_fields[3]);

            new_log_row.SubItems.Add(status);
            new_log_row.SubItems.Add(address);
            new_log_row.SubItems.Add(time);
            log_list.Items.Insert(0, new_log_row);
        }
        //delete history
        private void clear_bt_Click(object sender, EventArgs e)
        {
            File.Delete("log.txt");
            log_list.Items.Clear();
        }
    }
}
