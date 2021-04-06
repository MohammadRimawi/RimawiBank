using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Mohammad_Rimawi_20180383_Project
{
    public partial class RimawiBank : Form
    {
        public RimawiBank()
        {
            InitializeComponent();
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Left = (this.Width / 2) - panel1.Width/2;
            panel1.Top = (this.Height / 2) - panel1.Height/2;
        }

        private void RimawiBank_Load(object sender, EventArgs e)
        {
            
            try
            {
                Account.ConnectDataBase();
                Account.OpenDataBaseConnection();
            //   Account.test();
            }
            catch
            {
                MessageBox.Show("The Bank is currntly out of service\nPlease try again later.");
                SignUp.Enabled = false;

            }
            
        }

        private void Login_Click(object sender, EventArgs e)
        {

             this.Hide();
            if (!Account.FindAccount(Username.Text, Password.Text))
            {
                this.Show();

            }
            else
            {
                this.Hide();
                Dashboard dash = new Dashboard();
                dash.ShowDialog();
                this.Close();
            }
            Password.Text = "";
        }

        private void SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signup = new SignUp();
            this.Hide();
            signup.ShowDialog();
            this.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
