namespace Mohammad_Rimawi_20180383_Project
{
    partial class RimawiBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RimawiBank));
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.SignUp = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(42, 148);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(177, 20);
            this.Username.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(42, 174);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(177, 20);
            this.Password.TabIndex = 2;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(42, 200);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(177, 30);
            this.Login.TabIndex = 3;
            this.Login.Text = "Log in";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // SignUp
            // 
            this.SignUp.AutoSize = true;
            this.SignUp.LinkColor = System.Drawing.Color.White;
            this.SignUp.Location = new System.Drawing.Point(108, 244);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(45, 13);
            this.SignUp.TabIndex = 5;
            this.SignUp.TabStop = true;
            this.SignUp.Text = "Sign Up";
            this.SignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUp_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.SignUp);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.Login);
            this.panel1.Location = new System.Drawing.Point(9, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 384);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome to";
            // 
            // RimawiBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(39)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(293, 542);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(309, 581);
            this.Name = "RimawiBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RimawiBank";
            this.Load += new System.EventHandler(this.RimawiBank_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.LinkLabel SignUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

