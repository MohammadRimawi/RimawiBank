namespace Mohammad_Rimawi_20180383_Project
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DepositAmount = new System.Windows.Forms.TextBox();
            this.WithdrawAmount = new System.Windows.Forms.TextBox();
            this.Deposit = new System.Windows.Forms.Button();
            this.Withdraw = new System.Windows.Forms.Button();
            this.SignOut = new System.Windows.Forms.Button();
            this.Balance = new System.Windows.Forms.Label();
            this.AccountType = new System.Windows.Forms.Label();
            this.VisaNumber = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.DepositAmount);
            this.panel1.Controls.Add(this.WithdrawAmount);
            this.panel1.Controls.Add(this.Deposit);
            this.panel1.Controls.Add(this.Withdraw);
            this.panel1.Controls.Add(this.SignOut);
            this.panel1.Controls.Add(this.Balance);
            this.panel1.Controls.Add(this.AccountType);
            this.panel1.Controls.Add(this.VisaNumber);
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Location = new System.Drawing.Point(24, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 407);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 351);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Print Log";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Show Log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(3, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(564, 150);
            this.dataGridView1.TabIndex = 22;
            // 
            // DepositAmount
            // 
            this.DepositAmount.Location = new System.Drawing.Point(444, 69);
            this.DepositAmount.Name = "DepositAmount";
            this.DepositAmount.Size = new System.Drawing.Size(100, 20);
            this.DepositAmount.TabIndex = 15;
            // 
            // WithdrawAmount
            // 
            this.WithdrawAmount.Location = new System.Drawing.Point(444, 95);
            this.WithdrawAmount.Name = "WithdrawAmount";
            this.WithdrawAmount.Size = new System.Drawing.Size(100, 20);
            this.WithdrawAmount.TabIndex = 17;
            // 
            // Deposit
            // 
            this.Deposit.Location = new System.Drawing.Point(363, 69);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(75, 23);
            this.Deposit.TabIndex = 16;
            this.Deposit.Text = "Deposit";
            this.Deposit.UseVisualStyleBackColor = true;
            this.Deposit.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // Withdraw
            // 
            this.Withdraw.Location = new System.Drawing.Point(363, 95);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(75, 23);
            this.Withdraw.TabIndex = 18;
            this.Withdraw.Text = "Withdraw";
            this.Withdraw.UseVisualStyleBackColor = true;
            this.Withdraw.Click += new System.EventHandler(this.Withdraw_Click);
            // 
            // SignOut
            // 
            this.SignOut.Location = new System.Drawing.Point(469, 24);
            this.SignOut.Name = "SignOut";
            this.SignOut.Size = new System.Drawing.Size(75, 23);
            this.SignOut.TabIndex = 19;
            this.SignOut.Text = "Sign Out";
            this.SignOut.UseVisualStyleBackColor = true;
            this.SignOut.Click += new System.EventHandler(this.SignOut_Click);
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.BackColor = System.Drawing.Color.Transparent;
            this.Balance.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance.ForeColor = System.Drawing.Color.White;
            this.Balance.Location = new System.Drawing.Point(18, 87);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(69, 18);
            this.Balance.TabIndex = 14;
            this.Balance.Text = "Balance";
            // 
            // AccountType
            // 
            this.AccountType.AutoSize = true;
            this.AccountType.BackColor = System.Drawing.Color.Transparent;
            this.AccountType.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountType.ForeColor = System.Drawing.Color.White;
            this.AccountType.Location = new System.Drawing.Point(18, 69);
            this.AccountType.Name = "AccountType";
            this.AccountType.Size = new System.Drawing.Size(106, 18);
            this.AccountType.TabIndex = 13;
            this.AccountType.Text = "AccountType";
            // 
            // VisaNumber
            // 
            this.VisaNumber.AutoSize = true;
            this.VisaNumber.BackColor = System.Drawing.Color.Transparent;
            this.VisaNumber.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisaNumber.ForeColor = System.Drawing.Color.White;
            this.VisaNumber.Location = new System.Drawing.Point(18, 49);
            this.VisaNumber.Name = "VisaNumber";
            this.VisaNumber.Size = new System.Drawing.Size(102, 18);
            this.VisaNumber.TabIndex = 12;
            this.VisaNumber.Text = "VisaNumber";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.BackColor = System.Drawing.Color.Transparent;
            this.UserName.Font = new System.Drawing.Font("Montserrat Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.White;
            this.UserName.Location = new System.Drawing.Point(13, 12);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(168, 37);
            this.UserName.TabIndex = 11;
            this.UserName.Text = "Username";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(460, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Delete Account";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(39)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(613, 478);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(629, 517);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox DepositAmount;
        private System.Windows.Forms.TextBox WithdrawAmount;
        private System.Windows.Forms.Button Deposit;
        private System.Windows.Forms.Button Withdraw;
        private System.Windows.Forms.Button SignOut;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.Label AccountType;
        private System.Windows.Forms.Label VisaNumber;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
    }
}