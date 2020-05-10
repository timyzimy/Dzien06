namespace MySQLConnect
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDBName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbSQL = new System.Windows.Forms.TextBox();
            this.btnRunSQL = new System.Windows.Forms.Button();
            this.lvGrid = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(100, 19);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(155, 20);
            this.tbHost.TabIndex = 1;
            this.tbHost.Text = "127.0.0.1";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(100, 58);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(155, 20);
            this.tbUser.TabIndex = 3;
            this.tbUser.Text = "root";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(100, 99);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(155, 20);
            this.tbPass.TabIndex = 5;
            this.tbPass.Text = "root";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pass";
            // 
            // tbDBName
            // 
            this.tbDBName.Location = new System.Drawing.Point(100, 143);
            this.tbDBName.Name = "tbDBName";
            this.tbDBName.Size = new System.Drawing.Size(155, 20);
            this.tbDBName.TabIndex = 7;
            this.tbDBName.Text = "classicmodels";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "DB Name";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(100, 189);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(155, 20);
            this.tbPort.TabIndex = 9;
            this.tbPort.Text = "3306";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Port";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(79, 230);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(127, 51);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Połacz";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbSQL
            // 
            this.tbSQL.Location = new System.Drawing.Point(274, 19);
            this.tbSQL.Multiline = true;
            this.tbSQL.Name = "tbSQL";
            this.tbSQL.Size = new System.Drawing.Size(440, 141);
            this.tbSQL.TabIndex = 11;
            this.tbSQL.Text = "\r\nSELECT * FROM \r\n PRODUCTS\r\n";
            // 
            // btnRunSQL
            // 
            this.btnRunSQL.Location = new System.Drawing.Point(737, 54);
            this.btnRunSQL.Name = "btnRunSQL";
            this.btnRunSQL.Size = new System.Drawing.Size(115, 65);
            this.btnRunSQL.TabIndex = 12;
            this.btnRunSQL.Text = "Wykonaj polecenie";
            this.btnRunSQL.UseVisualStyleBackColor = true;
            this.btnRunSQL.Click += new System.EventHandler(this.btnRunSQL_Click);
            // 
            // lvGrid
            // 
            this.lvGrid.Location = new System.Drawing.Point(274, 184);
            this.lvGrid.Name = "lvGrid";
            this.lvGrid.Size = new System.Drawing.Size(750, 328);
            this.lvGrid.TabIndex = 13;
            this.lvGrid.UseCompatibleStateImageBehavior = false;
            this.lvGrid.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 545);
            this.Controls.Add(this.lvGrid);
            this.Controls.Add(this.btnRunSQL);
            this.Controls.Add(this.tbSQL);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDBName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDBName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbSQL;
        private System.Windows.Forms.Button btnRunSQL;
        private System.Windows.Forms.ListView lvGrid;
    }
}

