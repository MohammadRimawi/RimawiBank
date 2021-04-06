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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void AddNewUser_Click(object sender, EventArgs e)
        {
            String Type;
            if (radioButton1.Checked) {
                Type = "Saving";
                Account newUser = new Account(Username.Text, Password.Text, Type, VisaNumber.Text);
               Account.AddUser(ref newUser);

            }
            else if (radioButton2.Checked) { 
                Type = "Current";
                Account newUser = new Account(Username.Text, Password.Text, Type, VisaNumber.Text);
                Account.AddUser(ref newUser);
                
            }
            else
            {
                MessageBox.Show("Please Choose your acount type");
            }

            this.Hide();
            Dashboard dash = new Dashboard();
            dash.ShowDialog();
            this.Close();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            Account.ComputeCurrentID();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Left = (this.Width / 2) - panel1.Width / 2;
            panel1.Top = (this.Height / 2) - panel1.Height / 2;
        }
    }
}
