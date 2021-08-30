namespace SpexaAntiDefender
{
    partial class frmVpn
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDısConnectVpn = new System.Windows.Forms.Button();
            this.btnConnectVpn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtHost = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUsrname = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(3, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "System Password : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Host :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnDısConnectVpn);
            this.panel1.Controls.Add(this.btnConnectVpn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtHost);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUsrname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(187, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 437);
            this.panel1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(195, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Disconnect";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(57, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Connect";
            // 
            // btnDısConnectVpn
            // 
            this.btnDısConnectVpn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnDısConnectVpn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDısConnectVpn.FlatAppearance.BorderSize = 0;
            this.btnDısConnectVpn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDısConnectVpn.Image = global::SpexaAntiDefender.Properties.Resources.icons8_disconnected_34;
            this.btnDısConnectVpn.Location = new System.Drawing.Point(168, 365);
            this.btnDısConnectVpn.Name = "btnDısConnectVpn";
            this.btnDısConnectVpn.Size = new System.Drawing.Size(129, 46);
            this.btnDısConnectVpn.TabIndex = 9;
            this.btnDısConnectVpn.UseVisualStyleBackColor = false;
            this.btnDısConnectVpn.Click += new System.EventHandler(this.btnDısConnectVpn_Click);
            // 
            // btnConnectVpn
            // 
            this.btnConnectVpn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnConnectVpn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnectVpn.FlatAppearance.BorderSize = 0;
            this.btnConnectVpn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectVpn.Image = global::SpexaAntiDefender.Properties.Resources.icons8_network_32;
            this.btnConnectVpn.Location = new System.Drawing.Point(17, 365);
            this.btnConnectVpn.Name = "btnConnectVpn";
            this.btnConnectVpn.Size = new System.Drawing.Size(127, 46);
            this.btnConnectVpn.TabIndex = 9;
            this.btnConnectVpn.UseVisualStyleBackColor = false;
            this.btnConnectVpn.Click += new System.EventHandler(this.btnConnectVpn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SpexaAntiDefender.Properties.Resources.icons8_connect_256;
            this.pictureBox1.Location = new System.Drawing.Point(70, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txtHost
            // 
            // 
            // 
            // 
            this.txtHost.CustomButton.Image = null;
            this.txtHost.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.txtHost.CustomButton.Name = "";
            this.txtHost.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtHost.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHost.CustomButton.TabIndex = 1;
            this.txtHost.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHost.CustomButton.UseSelectable = true;
            this.txtHost.CustomButton.Visible = false;
            this.txtHost.DisplayIcon = true;
            this.txtHost.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHost.Icon = global::SpexaAntiDefender.Properties.Resources.icons8_switch_host_20;
            this.txtHost.Lines = new string[0];
            this.txtHost.Location = new System.Drawing.Point(151, 184);
            this.txtHost.MaxLength = 32767;
            this.txtHost.Name = "txtHost";
            this.txtHost.PasswordChar = '\0';
            this.txtHost.PromptText = "Enter Host Address";
            this.txtHost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHost.SelectedText = "";
            this.txtHost.SelectionLength = 0;
            this.txtHost.SelectionStart = 0;
            this.txtHost.ShortcutsEnabled = true;
            this.txtHost.Size = new System.Drawing.Size(156, 27);
            this.txtHost.TabIndex = 7;
            this.txtHost.UseSelectable = true;
            this.txtHost.WaterMark = "Enter Host Address";
            this.txtHost.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHost.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtHost.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.Icon = global::SpexaAntiDefender.Properties.Resources.icons8_forgot_password_20;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(151, 308);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PromptText = "Password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(156, 27);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUsrname
            // 
            // 
            // 
            // 
            this.txtUsrname.CustomButton.Image = null;
            this.txtUsrname.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.txtUsrname.CustomButton.Name = "";
            this.txtUsrname.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtUsrname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsrname.CustomButton.TabIndex = 1;
            this.txtUsrname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsrname.CustomButton.UseSelectable = true;
            this.txtUsrname.CustomButton.Visible = false;
            this.txtUsrname.DisplayIcon = true;
            this.txtUsrname.Icon = global::SpexaAntiDefender.Properties.Resources.icons8_username_20;
            this.txtUsrname.Lines = new string[0];
            this.txtUsrname.Location = new System.Drawing.Point(151, 247);
            this.txtUsrname.MaxLength = 32767;
            this.txtUsrname.Name = "txtUsrname";
            this.txtUsrname.PasswordChar = '\0';
            this.txtUsrname.PromptText = "User-name";
            this.txtUsrname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsrname.SelectedText = "";
            this.txtUsrname.SelectionLength = 0;
            this.txtUsrname.SelectionStart = 0;
            this.txtUsrname.ShortcutsEnabled = true;
            this.txtUsrname.Size = new System.Drawing.Size(156, 27);
            this.txtUsrname.TabIndex = 6;
            this.txtUsrname.UseSelectable = true;
            this.txtUsrname.WaterMark = "User-name";
            this.txtUsrname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsrname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmVpn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVpn";
            this.Text = "ş";
            this.Load += new System.EventHandler(this.frmVpn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtUsrname;
        private MetroFramework.Controls.MetroTextBox txtHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConnectVpn;
        private System.Windows.Forms.Button btnDısConnectVpn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}