namespace Mohammad_Rimawi_20180383_Project
{
    partial class ControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConnectDataBase = new System.Windows.Forms.Button();
            this.ShowUsers = new System.Windows.Forms.Button();
            this.OpenConnection = new System.Windows.Forms.Button();
            this.CloseConnection = new System.Windows.Forms.Button();
            this.CreateDataBase = new System.Windows.Forms.Button();
            this.CreateTables = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ConnectDataBase);
            this.panel1.Controls.Add(this.ShowUsers);
            this.panel1.Controls.Add(this.OpenConnection);
            this.panel1.Controls.Add(this.CloseConnection);
            this.panel1.Controls.Add(this.CreateDataBase);
            this.panel1.Controls.Add(this.CreateTables);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 356);
            this.panel1.TabIndex = 6;
            // 
            // ConnectDataBase
            // 
            this.ConnectDataBase.Location = new System.Drawing.Point(105, 119);
            this.ConnectDataBase.Name = "ConnectDataBase";
            this.ConnectDataBase.Size = new System.Drawing.Size(108, 23);
            this.ConnectDataBase.TabIndex = 2;
            this.ConnectDataBase.Text = "Create Connection";
            this.ConnectDataBase.UseVisualStyleBackColor = true;
            this.ConnectDataBase.Click += new System.EventHandler(this.ConnectDataBase_Click);
            // 
            // ShowUsers
            // 
            this.ShowUsers.Location = new System.Drawing.Point(105, 235);
            this.ShowUsers.Name = "ShowUsers";
            this.ShowUsers.Size = new System.Drawing.Size(108, 23);
            this.ShowUsers.TabIndex = 5;
            this.ShowUsers.Text = "Show Users";
            this.ShowUsers.UseVisualStyleBackColor = true;
            this.ShowUsers.Click += new System.EventHandler(this.ShowUsers_Click);
            // 
            // OpenConnection
            // 
            this.OpenConnection.Location = new System.Drawing.Point(105, 148);
            this.OpenConnection.Name = "OpenConnection";
            this.OpenConnection.Size = new System.Drawing.Size(108, 23);
            this.OpenConnection.TabIndex = 2;
            this.OpenConnection.Text = "Open Connection";
            this.OpenConnection.UseVisualStyleBackColor = true;
            this.OpenConnection.Click += new System.EventHandler(this.OpenConnection_Click);
            // 
            // CloseConnection
            // 
            this.CloseConnection.Location = new System.Drawing.Point(105, 177);
            this.CloseConnection.Name = "CloseConnection";
            this.CloseConnection.Size = new System.Drawing.Size(108, 23);
            this.CloseConnection.TabIndex = 3;
            this.CloseConnection.Text = "Close Connection";
            this.CloseConnection.UseVisualStyleBackColor = true;
            this.CloseConnection.Click += new System.EventHandler(this.CloseConnection_Click);
            // 
            // CreateDataBase
            // 
            this.CreateDataBase.Location = new System.Drawing.Point(105, 90);
            this.CreateDataBase.Name = "CreateDataBase";
            this.CreateDataBase.Size = new System.Drawing.Size(108, 23);
            this.CreateDataBase.TabIndex = 1;
            this.CreateDataBase.Text = "Create Data Base";
            this.CreateDataBase.UseVisualStyleBackColor = true;
            this.CreateDataBase.Click += new System.EventHandler(this.CreateDataBase_Click);
            // 
            // CreateTables
            // 
            this.CreateTables.Location = new System.Drawing.Point(105, 206);
            this.CreateTables.Name = "CreateTables";
            this.CreateTables.Size = new System.Drawing.Size(108, 23);
            this.CreateTables.TabIndex = 4;
            this.CreateTables.Text = "Create Tables";
            this.CreateTables.UseVisualStyleBackColor = true;
            this.CreateTables.Click += new System.EventHandler(this.CreateTables_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "With Great Power Comes\r\n Great Responablities";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(39)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(352, 450);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(368, 489);
            this.Name = "ControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Panel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConnectDataBase;
        private System.Windows.Forms.Button ShowUsers;
        private System.Windows.Forms.Button OpenConnection;
        private System.Windows.Forms.Button CloseConnection;
        private System.Windows.Forms.Button CreateDataBase;
        private System.Windows.Forms.Button CreateTables;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}