namespace SpexaAntiDefender
{
    partial class frmNetworkScan
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvResult = new System.Windows.Forms.ListView();
            this.progressBar = new CircularProgressBar.CircularProgressBar();
            this.btnScanner = new System.Windows.Forms.Button();
            this.tbScanIP = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStatus.Location = new System.Drawing.Point(534, 244);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 20);
            this.lblStatus.TabIndex = 1;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IP Address";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Host Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 140;
            // 
            // lvResult
            // 
            this.lvResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.lvResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvResult.ForeColor = System.Drawing.Color.GreenYellow;
            this.lvResult.HideSelection = false;
            this.lvResult.Location = new System.Drawing.Point(44, 60);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(364, 184);
            this.lvResult.TabIndex = 9;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.View = System.Windows.Forms.View.Details;
            // 
            // progressBar
            // 
            this.progressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progressBar.AnimationSpeed = 500;
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.progressBar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBar.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.progressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.progressBar.InnerMargin = 2;
            this.progressBar.InnerWidth = -1;
            this.progressBar.Location = new System.Drawing.Point(524, 86);
            this.progressBar.MarqueeAnimationSpeed = 2000;
            this.progressBar.Name = "progressBar";
            this.progressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.progressBar.OuterMargin = -25;
            this.progressBar.OuterWidth = 26;
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.progressBar.ProgressWidth = 6;
            this.progressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progressBar.Size = new System.Drawing.Size(125, 123);
            this.progressBar.StartAngle = 270;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressBar.SubscriptText = "";
            this.progressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressBar.SuperscriptText = "";
            this.progressBar.TabIndex = 10;
            this.progressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progressBar.Value = 68;
            this.progressBar.Visible = false;
            // 
            // btnScanner
            // 
            this.btnScanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnScanner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScanner.FlatAppearance.BorderSize = 0;
            this.btnScanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanner.Image = global::SpexaAntiDefender.Properties.Resources.icons8_wi_fi_96;
            this.btnScanner.Location = new System.Drawing.Point(65, 271);
            this.btnScanner.Name = "btnScanner";
            this.btnScanner.Size = new System.Drawing.Size(127, 66);
            this.btnScanner.TabIndex = 2;
            this.btnScanner.UseVisualStyleBackColor = false;
            this.btnScanner.Click += new System.EventHandler(this.btnScanner_Click);
            // 
            // tbScanIP
            // 
            // 
            // 
            // 
            this.tbScanIP.CustomButton.Image = null;
            this.tbScanIP.CustomButton.Location = new System.Drawing.Point(120, 2);
            this.tbScanIP.CustomButton.Name = "";
            this.tbScanIP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbScanIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbScanIP.CustomButton.TabIndex = 1;
            this.tbScanIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbScanIP.CustomButton.UseSelectable = true;
            this.tbScanIP.CustomButton.Visible = false;
            this.tbScanIP.DisplayIcon = true;
            this.tbScanIP.Icon = global::SpexaAntiDefender.Properties.Resources.icons8_switch_host_20;
            this.tbScanIP.Lines = new string[0];
            this.tbScanIP.Location = new System.Drawing.Point(243, 271);
            this.tbScanIP.MaxLength = 32767;
            this.tbScanIP.Name = "tbScanIP";
            this.tbScanIP.PasswordChar = '\0';
            this.tbScanIP.PromptText = "Enter Ip Addresse";
            this.tbScanIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbScanIP.SelectedText = "";
            this.tbScanIP.SelectionLength = 0;
            this.tbScanIP.SelectionStart = 0;
            this.tbScanIP.ShortcutsEnabled = true;
            this.tbScanIP.Size = new System.Drawing.Size(144, 26);
            this.tbScanIP.TabIndex = 12;
            this.tbScanIP.UseSelectable = true;
            this.tbScanIP.WaterMark = "Enter Ip Addresse";
            this.tbScanIP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbScanIP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(108, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Scan";
            // 
            // frmNetworkScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbScanIP);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lvResult);
            this.Controls.Add(this.btnScanner);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNetworkScan";
            this.Text = "frmNetworkScan";
            this.Load += new System.EventHandler(this.frmNetworkScan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnScanner;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvResult;
        private CircularProgressBar.CircularProgressBar progressBar;
        private MetroFramework.Controls.MetroTextBox tbScanIP;
        private System.Windows.Forms.Label label1;
    }
}