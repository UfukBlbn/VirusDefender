namespace SpexaAntiDefender
{
    partial class frmFileEncyrpt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.tPath = new System.Windows.Forms.TextBox();
            this.btnBrows = new System.Windows.Forms.Button();
            this.rbEncyrpt = new System.Windows.Forms.RadioButton();
            this.rbDecyrpt = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataLister = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataLister)).BeginInit();
            this.SuspendLayout();
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(109, 296);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(169, 20);
            this.tPassword.TabIndex = 0;
            this.tPassword.UseSystemPasswordChar = true;
            // 
            // tPath
            // 
            this.tPath.Location = new System.Drawing.Point(109, 159);
            this.tPath.Name = "tPath";
            this.tPath.Size = new System.Drawing.Size(251, 20);
            this.tPath.TabIndex = 0;
            // 
            // btnBrows
            // 
            this.btnBrows.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBrows.FlatAppearance.BorderSize = 0;
            this.btnBrows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrows.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBrows.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBrows.Location = new System.Drawing.Point(109, 205);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(119, 23);
            this.btnBrows.TabIndex = 1;
            this.btnBrows.Text = "Browse";
            this.btnBrows.UseVisualStyleBackColor = false;
            this.btnBrows.Click += new System.EventHandler(this.btnBrows_Click);
            // 
            // rbEncyrpt
            // 
            this.rbEncyrpt.AutoSize = true;
            this.rbEncyrpt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbEncyrpt.Location = new System.Drawing.Point(109, 336);
            this.rbEncyrpt.Name = "rbEncyrpt";
            this.rbEncyrpt.Size = new System.Drawing.Size(69, 21);
            this.rbEncyrpt.TabIndex = 2;
            this.rbEncyrpt.TabStop = true;
            this.rbEncyrpt.Text = "Encyrpt";
            this.rbEncyrpt.UseVisualStyleBackColor = true;
            this.rbEncyrpt.CheckedChanged += new System.EventHandler(this.rbEncyrpt_CheckedChanged);
            // 
            // rbDecyrpt
            // 
            this.rbDecyrpt.AutoSize = true;
            this.rbDecyrpt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbDecyrpt.Location = new System.Drawing.Point(216, 336);
            this.rbDecyrpt.Name = "rbDecyrpt";
            this.rbDecyrpt.Size = new System.Drawing.Size(71, 21);
            this.rbDecyrpt.TabIndex = 2;
            this.rbDecyrpt.TabStop = true;
            this.rbDecyrpt.Text = "Decyrpt";
            this.rbDecyrpt.UseVisualStyleBackColor = true;
            this.rbDecyrpt.CheckedChanged += new System.EventHandler(this.rbDecyrpt_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(109, 406);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(166, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start Process";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(671, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "You can encrypt your own by choosing your files, the list on the side shows your " +
    "encrypted files.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(422, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Encyrpted File List";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(468, 416);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(608, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataLister
            // 
            this.dataLister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataLister.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataLister.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataLister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataLister.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataLister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataLister.ColumnHeadersHeight = 25;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataLister.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataLister.EnableHeadersVisualStyles = false;
            this.dataLister.GridColor = System.Drawing.Color.SteelBlue;
            this.dataLister.Location = new System.Drawing.Point(425, 146);
            this.dataLister.Name = "dataLister";
            this.dataLister.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLister.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataLister.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataLister.Size = new System.Drawing.Size(218, 223);
            this.dataLister.TabIndex = 11;
            // 
            // frmFileEncyrpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(758, 477);
            this.Controls.Add(this.dataLister);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbDecyrpt);
            this.Controls.Add(this.rbEncyrpt);
            this.Controls.Add(this.btnBrows);
            this.Controls.Add(this.tPath);
            this.Controls.Add(this.tPassword);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFileEncyrpt";
            this.Text = "Encyrption";
            this.Load += new System.EventHandler(this.frmFileEncyrpt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.TextBox tPath;
        private System.Windows.Forms.Button btnBrows;
        private System.Windows.Forms.RadioButton rbEncyrpt;
        private System.Windows.Forms.RadioButton rbDecyrpt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataLister;
    }
}