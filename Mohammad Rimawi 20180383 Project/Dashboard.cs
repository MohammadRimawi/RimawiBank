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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        static Account MainAccount;
        
            static public string ID { set; get; }
        private void SignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            RimawiBank portal = new RimawiBank();
            portal.ShowDialog();
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            MainAccount = Account.mainAccount(ID);
            UserName.Text = MainAccount.Username.ToUpper();
            AccountType.Text ="Account Type: "+ MainAccount.Type;
            VisaNumber.Text ="Visa Number: "+ MainAccount.VisaNumber;
            Balance.Text ="Current Balance: $"+ MainAccount.Balance.ToString();
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            try
            {

           if(MainAccount.Deposit(Double.Parse(DepositAmount.Text)))
            {
                MainAccount.Balance += Double.Parse(DepositAmount.Text);
                MessageBox.Show($"{DepositAmount.Text} has be added to your account\nYour Current Balance= {MainAccount.Balance}");
                Balance.Text = "Current Balance: $" + MainAccount.Balance.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a positive number");
            }

            }
            catch
            {
                MessageBox.Show("Please enter a positive number");
            }
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            try
            {
                if (Double.Parse(WithdrawAmount.Text) < 0)
                {
                    int x = 1;
                    x = x / 0;
                }
                if (MainAccount.Withdraw(Double.Parse(WithdrawAmount.Text)))
                {
                    
                    MainAccount.Balance -= Double.Parse(WithdrawAmount.Text);
                    MessageBox.Show($"{WithdrawAmount.Text} has be Withdrawed from your account\nYour Current Balance= {MainAccount.Balance}");
                    Balance.Text = "Current Balance: $" + MainAccount.Balance.ToString();
                }
                else
                {
                    MessageBox.Show("Sorry, you don't have enough Balance");
                }
            }
            
            catch
            {
                MessageBox.Show("Please Enter a positive number");
            }       
           }
            


        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter da = MainAccount.Transactions();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainAccount.PrintInformation();
        }

        private void UserName_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Left = (this.Width / 2) - panel1.Width / 2;
            panel1.Top = (this.Height / 2) - panel1.Height / 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete your Account?", "", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

            MainAccount.DeleteMyAccount();
            
            this.Hide();
                MessageBox.Show("Your account has been deleted successfuly");
            RimawiBank portal = new RimawiBank();
            portal.ShowDialog();
            this.Close();
                
            }
        }
    }
}
