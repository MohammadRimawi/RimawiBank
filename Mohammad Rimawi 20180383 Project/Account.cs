using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
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
using System.IO;

namespace Mohammad_Rimawi_20180383_Project
{
    class Account
    {


       static SQLiteConnection DataBaseConnection;

        static private int ID { get; set; }
        static public void ComputeCurrentID()
        {
            try
            {
                String order = "SELECT MAX(AccountID) AS ID FROM Accounts";
                SQLiteCommand command = new SQLiteCommand(order, DataBaseConnection);
                SQLiteDataReader reader = command.ExecuteReader();
            reader.Read();
                ID = int.Parse(reader["ID"].ToString());
                ID++;
            }
            catch
            {
                ID = 0;
            }
        }
       public Account(String U,String P,String T,String V)
        {
            Password = PasswordHashing(P);
            Username = U.ToLower();
            Type = T;
            VisaNumber = V;
            Balance = 0;
            AccountID = ID;
        }
        public Account(String U, String P, String T, String V,String B)
        {
            Password = PasswordHashing(P);
            Username = U.ToLower();
            Type = T;
            VisaNumber = V;
            Balance =Double.Parse(B);
            AccountID = ID;

        }

        public Account(ref Account temp)
        {
            Password = temp.Password;
            Username = temp.Username;
            Type = temp.Type;
            VisaNumber = temp.VisaNumber;
            Balance = temp.Balance;
            AccountID = temp.AccountID;
        }
        private int AccountID { set; get; }
        private string Password { set; get; }
        public string Username { set; get; }
        public string Type { set; get; }
        public string VisaNumber { set; get; }
        public Double Balance { set; get; }
        static public string PasswordHashing(string p)
        {
            long pass =  long.Parse(p);
            pass= (pass*427349482742+1234)%50000;
            
            return pass.ToString();

        }
        static public bool FindAccount(string U,string P)
        {
                if (U.ToLower() == "admin" && P == "1234")
            {
                ControlPanel Admin = new ControlPanel();
                Admin.ShowDialog();
                return false;
            }
            try
            {

            String order = "SELECT * FROM Accounts \n WHERE Username= '" + U.ToLower() + "' AND Password='"+PasswordHashing(P)+"'";
            SQLiteCommand command = new SQLiteCommand(order, DataBaseConnection);
            
           
            SQLiteDataReader reader = command.ExecuteReader();
                if (reader["AccountID"].ToString() == "")
                {
                    MessageBox.Show("Account not found or Password is not correct", "RimawiBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else { 
           
                    Dashboard.ID =reader["AccountID"].ToString();
                
                return true;
                }

            }
            catch
            {
                MessageBox.Show("Account not found or Password is not correct", "RimawiBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            
        }
        static public void ConnectDataBase()
        {
            DataBaseConnection = new SQLiteConnection("Data Source=RimawiBank.sqlite; Version=3;");
        }
        static public void CreateDataBase()
        {
            DialogResult result = MessageBox.Show("Creating Data Base may cause to delete the Original Data Base.\nAre you Sure you want to proceed? ", "Data Base Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
            SQLiteConnection.CreateFile("RimawiBank.sqlite");
                MessageBox.Show("Data Base has been created successfuly!", "Data Base Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Base was not created!", "Data Base Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        static public void CreatTables()
        {
            String order = "CREATE TABLE Accounts (AccountID VARCHAR(20), Username VARCHAR(20),Password VARCHAR(20))";
            SQLiteCommand command = new SQLiteCommand(order, DataBaseConnection);
            command.ExecuteNonQuery();

            order = "CREATE TABLE Users (AccountID INT,AccountType VARCHAR(20),VisaNumber VARCHAR(15),Balance DOUBLE)";
            command = new SQLiteCommand(order, DataBaseConnection);
            command.ExecuteNonQuery();


            order = "CREATE TABLE Transactions (AccountID INT,Date DATETIME,TransactionType VARCHAR(20),Amount DOUBLE,Balance DOUBLE)";
            command = new SQLiteCommand(order, DataBaseConnection);
            command.ExecuteNonQuery();


            

        }
        static public void AddUser(ref Account newUser)
        {
          
            try
            {
                string order = "INSERT INTO Accounts (AccountID, Username, Password) values ("+newUser.AccountID.ToString()+", '"+newUser.Username+"', '"+newUser.Password+"')";
                SQLiteCommand command = new SQLiteCommand(order, DataBaseConnection);
                command.ExecuteNonQuery();

                order = "INSERT INTO Users (AccountID,AccountType,VisaNumber,Balance) values (" + newUser.AccountID.ToString() + ", '" + newUser.Type + "', '" + newUser.VisaNumber + "',"+newUser.Balance+")";
                command = new SQLiteCommand(order, DataBaseConnection);
                command.ExecuteNonQuery();
                
                Dashboard.ID = newUser.AccountID.ToString();

                MessageBox.Show("User was added successfuly");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString());
            }

        }
        static public void OpenDataBaseConnection()
        {
            DataBaseConnection.Open();
        }
        static public void CloseDataBaseConnection()
        {
            DataBaseConnection.Close();
        }
        static public void ReadUseres()
        {
            
                string sql = "SELECT * FROM Accounts";
                SQLiteCommand command = new SQLiteCommand(sql, DataBaseConnection);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    MessageBox.Show("UserName: " + reader["Username"] + "\nAccountID: " + reader["AccountID"]+"\nHashedPassword: " +reader["Password"]);
                }
        }

    static public Account mainAccount(String ID)
    {
        String order = "SELECT * FROM Accounts \n WHERE AccountID= "+ID+"";
        SQLiteCommand command = new SQLiteCommand(order, DataBaseConnection);


        SQLiteDataReader reader1 = command.ExecuteReader();

        Dashboard.ID = reader1["AccountID"].ToString();

             order = "SELECT * FROM Users \n WHERE AccountID= " + ID + "";
             command = new SQLiteCommand(order, DataBaseConnection);
            SQLiteDataReader reader2 = command.ExecuteReader();

        Account temp=new Account( reader1["Username"].ToString(), reader1["Password"].ToString(), reader2["AccountType"].ToString(),reader2["VisaNumber"].ToString(),reader2["Balance"].ToString());
        return temp;
    }

        public bool Withdraw(Double Amount)
        {
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");

            if (Balance >= Amount)
            {
                String order = "UPDATE Users SET Balance = "+(Balance-Amount).ToString()+" WHERE AccountID = "+AccountID.ToString()+"";
                SQLiteCommand command = new SQLiteCommand(order, DataBaseConnection);
                command.ExecuteNonQuery();

                order = "INSERT INTO Transactions (AccountID,Date,TransactionType,Amount,Balance) values (" + AccountID.ToString()+",'"+ sqlFormattedDate + "','Withdraw',"+Amount.ToString()+","+(Balance - Amount).ToString()+")";
                command = new SQLiteCommand(order, DataBaseConnection);
                command.ExecuteNonQuery();

                return true;
            }
            else
            {
               String order = "INSERT INTO Transactions (AccountID,Date,TransactionType,Amount,Balance) values (" + AccountID.ToString() + ",'" + sqlFormattedDate + "','Atempt to Withdraw'," + Amount.ToString() + "," + Balance.ToString() + ")";
               SQLiteCommand command = new SQLiteCommand(order, DataBaseConnection);
                command.ExecuteNonQuery();
                return false;
            }

        }

        public bool Deposit(Double Amount)
        {
            DateTime myDateTime = DateTime.Now;

            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            
                if (Amount > 0)
                {
                    String order = "UPDATE Users SET Balance = " + (Balance + Amount).ToString() + " \nWHERE AccountID = " + AccountID.ToString();
                    SQLiteCommand command = new SQLiteCommand(order, DataBaseConnection);
                    command.ExecuteNonQuery();

                    order = "INSERT INTO Transactions (AccountID,Date,TransactionType,Amount,Balance) values (" + AccountID.ToString() + ",'" + sqlFormattedDate + "','Deposit'," + Amount.ToString() + "," + (Balance + Amount).ToString() + ")";
                    command = new SQLiteCommand(order, DataBaseConnection);
                    command.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    return false;
                }
          
        }
        public SQLiteDataAdapter Transactions()
        {
            string sql = "SELECT * FROM Transactions WHERE AccountID="+ Dashboard.ID + " order by Date desc";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, DataBaseConnection);
            SQLiteCommandBuilder sql_command_builder = new SQLiteCommandBuilder(da);
            DataSet ds = new DataSet();
            return da;
        }

        public void PrintInformation()
        {
            string order = "SELECT * FROM Transactions WHERE AccountID=" + Dashboard.ID + " order by Date desc";
            SQLiteCommand command = new SQLiteCommand(order, DataBaseConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            string s = "";
            s += "*****************************************************************************************\n";
            s += "*****************************************************************************************\n";
            s += "**********									*********\n";
            s += "**********				RIMAWI BANK				*********\n";
            s += "**********									*********\n";
            s += "*****************************************************************************************\n";
            s += "*****************************************************************************************\n";
            s += $"Username: {Username}\n";
            s += $"Account Type: {Type}\n";
            s += $"Visa: {VisaNumber}\n";
            s += $"Balance: {Balance}\n";
            s += "*****************************************************************************************\n";
            s += "*****************************************************************************************\n";
            s += "+---------------------------------------------------------------------------------------+\n";
            s += "|	  DATE		|	   Transaction		|    Ammount	|     Balance\t|\n";
            s += "|---------------------------------------------------------------------------------------|\n";

            while (reader.Read())
            {
                if(reader["TransactionType"].ToString()== "Atempt to Withdraw")
                {
                  s +="| "+reader["Date"] + "\t|\t" + reader["TransactionType"].ToString() + "\t|\t" + reader["Amount"] + "\t|\t" + reader["Balance"] + "\t|\n";

                }
                else
                {
                s += "| " + reader["Date"] + "\t|\t     " + reader["TransactionType"].ToString() + "\t\t|\t" + reader["Amount"] + "\t|\t" + reader["Balance"] + "\t|\n";
                }
            }
            s += "+---------------------------------------------------------------------------------------+\n";
            s += "*****************************************************************************************\n";
            s += "*****************************************************************************************\n";
            //MessageBox.Show(s);
            StreamWriter writer = new StreamWriter("Receipt.txt");
            writer.Write(s);
            writer.Close();
            System.Diagnostics.Process.Start("Receipt.txt");
        }
        public void DeleteMyAccount()
        {
            string order = "DELETE FROM Transactions WHERE AccountID = " +Dashboard.ID+ ";";
            SQLiteCommand command = new SQLiteCommand(order, DataBaseConnection);
            command.ExecuteNonQuery();

            order = "DELETE FROM Users WHERE AccountID = " + Dashboard.ID + ";";
            command = new SQLiteCommand(order, DataBaseConnection);
            command.ExecuteNonQuery();

            order = "DELETE FROM Accounts WHERE AccountID = " + Dashboard.ID + ";";
            command = new SQLiteCommand(order, DataBaseConnection);
            command.ExecuteNonQuery();

           
           
        }

    }

}
