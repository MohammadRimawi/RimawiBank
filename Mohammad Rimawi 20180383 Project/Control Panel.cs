using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mohammad_Rimawi_20180383_Project
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void OpenConnection_Click(object sender, EventArgs e)
        {
            Account.OpenDataBaseConnection();
        }

        private void CreateDataBase_Click(object sender, EventArgs e)
        {
            Account.CreateDataBase();
        }

        private void CreateTables_Click(object sender, EventArgs e)
        {
            Account.CreatTables();
        }

        private void CloseConnection_Click(object sender, EventArgs e)
        {
            Account.CloseDataBaseConnection();
            //Add Bank out of Service Messege
        }

        private void ConnectDataBase_Click(object sender, EventArgs e)
        {
            Account.ConnectDataBase();
        }

        private void ShowUsers_Click(object sender, EventArgs e)
        {
            Account.ReadUseres();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Left = (this.Width / 2) - panel1.Width / 2;
            panel1.Top = (this.Height / 2) - panel1.Height / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
