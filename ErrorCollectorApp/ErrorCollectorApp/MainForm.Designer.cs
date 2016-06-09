namespace ErrorCollectorApp
{
    partial class MainForm
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
            this.checkBoxSAA = new System.Windows.Forms.CheckBox();
            this.checkBoxSWPSE = new System.Windows.Forms.CheckBox();
            this.checkBoxSAGSNL = new System.Windows.Forms.CheckBox();
            this.checkBoxSNL = new System.Windows.Forms.CheckBox();
            this.checkBoxEventLog = new System.Windows.Forms.CheckBox();
            this.groupBoxSAA = new System.Windows.Forms.GroupBox();
            this.buttonSAA = new System.Windows.Forms.Button();
            this.labelSAA = new System.Windows.Forms.Label();
            this.textBoxSAA = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxSWPSE = new System.Windows.Forms.GroupBox();
            this.buttonSWPSE = new System.Windows.Forms.Button();
            this.labelSWPSE = new System.Windows.Forms.Label();
            this.textBoxSWPSE = new System.Windows.Forms.TextBox();
            this.groupBoxSAGSNL = new System.Windows.Forms.GroupBox();
            this.buttonSNLplus = new System.Windows.Forms.Button();
            this.labelSNLplus = new System.Windows.Forms.Label();
            this.textBoxSNLplus = new System.Windows.Forms.TextBox();
            this.buttonSAGSNL = new System.Windows.Forms.Button();
            this.labelSAGSNL = new System.Windows.Forms.Label();
            this.textBoxSAGSNL = new System.Windows.Forms.TextBox();
            this.groupBoxSNL = new System.Windows.Forms.GroupBox();
            this.buttonSNL = new System.Windows.Forms.Button();
            this.labelSNL = new System.Windows.Forms.Label();
            this.textBoxSNL = new System.Windows.Forms.TextBox();
            this.groupBoxSAA.SuspendLayout();
            this.groupBoxSWPSE.SuspendLayout();
            this.groupBoxSAGSNL.SuspendLayout();
            this.groupBoxSNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxSAA
            // 
            this.checkBoxSAA.AutoSize = true;
            this.checkBoxSAA.Location = new System.Drawing.Point(12, 12);
            this.checkBoxSAA.Name = "checkBoxSAA";
            this.checkBoxSAA.Size = new System.Drawing.Size(167, 17);
            this.checkBoxSAA.TabIndex = 0;
            this.checkBoxSAA.Text = "SWIFT Alliance Access/Entry";
            this.checkBoxSAA.UseVisualStyleBackColor = true;
            this.checkBoxSAA.CheckedChanged += new System.EventHandler(this.checkBoxSAA_CheckedChanged);
            // 
            // checkBoxSWPSE
            // 
            this.checkBoxSWPSE.AutoSize = true;
            this.checkBoxSWPSE.Location = new System.Drawing.Point(12, 104);
            this.checkBoxSWPSE.Name = "checkBoxSWPSE";
            this.checkBoxSWPSE.Size = new System.Drawing.Size(167, 17);
            this.checkBoxSWPSE.TabIndex = 1;
            this.checkBoxSWPSE.Text = "SWIFT Alliance Web Platform";
            this.checkBoxSWPSE.UseVisualStyleBackColor = true;
            this.checkBoxSWPSE.CheckedChanged += new System.EventHandler(this.checkBoxSWPSE_CheckedChanged);
            // 
            // checkBoxSAGSNL
            // 
            this.checkBoxSAGSNL.AutoSize = true;
            this.checkBoxSAGSNL.Location = new System.Drawing.Point(12, 195);
            this.checkBoxSAGSNL.Name = "checkBoxSAGSNL";
            this.checkBoxSAGSNL.Size = new System.Drawing.Size(231, 17);
            this.checkBoxSAGSNL.TabIndex = 2;
            this.checkBoxSAGSNL.Text = "SWIFT Alliance Gateway + SWIFTNet Link";
            this.checkBoxSAGSNL.UseVisualStyleBackColor = true;
            this.checkBoxSAGSNL.CheckedChanged += new System.EventHandler(this.checkBoxSAGSNL_CheckedChanged);
            // 
            // checkBoxSNL
            // 
            this.checkBoxSNL.AutoSize = true;
            this.checkBoxSNL.Location = new System.Drawing.Point(12, 309);
            this.checkBoxSNL.Name = "checkBoxSNL";
            this.checkBoxSNL.Size = new System.Drawing.Size(124, 17);
            this.checkBoxSNL.TabIndex = 3;
            this.checkBoxSNL.Text = "SWIFTNet Link Only";
            this.checkBoxSNL.UseVisualStyleBackColor = true;
            this.checkBoxSNL.CheckedChanged += new System.EventHandler(this.checkBoxSNL_CheckedChanged);
            // 
            // checkBoxEventLog
            // 
            this.checkBoxEventLog.AutoSize = true;
            this.checkBoxEventLog.Location = new System.Drawing.Point(12, 398);
            this.checkBoxEventLog.Name = "checkBoxEventLog";
            this.checkBoxEventLog.Size = new System.Drawing.Size(71, 17);
            this.checkBoxEventLog.TabIndex = 4;
            this.checkBoxEventLog.Text = "Event log";
            this.checkBoxEventLog.UseVisualStyleBackColor = true;
            // 
            // groupBoxSAA
            // 
            this.groupBoxSAA.Controls.Add(this.buttonSAA);
            this.groupBoxSAA.Controls.Add(this.labelSAA);
            this.groupBoxSAA.Controls.Add(this.textBoxSAA);
            this.groupBoxSAA.Enabled = false;
            this.groupBoxSAA.Location = new System.Drawing.Point(12, 35);
            this.groupBoxSAA.Name = "groupBoxSAA";
            this.groupBoxSAA.Size = new System.Drawing.Size(531, 51);
            this.groupBoxSAA.TabIndex = 5;
            this.groupBoxSAA.TabStop = false;
            // 
            // buttonSAA
            // 
            this.buttonSAA.Location = new System.Drawing.Point(428, 15);
            this.buttonSAA.Name = "buttonSAA";
            this.buttonSAA.Size = new System.Drawing.Size(97, 23);
            this.buttonSAA.TabIndex = 3;
            this.buttonSAA.Text = "Manual browse";
            this.buttonSAA.UseVisualStyleBackColor = true;
            this.buttonSAA.Click += new System.EventHandler(this.buttonSAA_Click);
            // 
            // labelSAA
            // 
            this.labelSAA.AutoSize = true;
            this.labelSAA.Location = new System.Drawing.Point(7, 20);
            this.labelSAA.Name = "labelSAA";
            this.labelSAA.Size = new System.Drawing.Size(96, 13);
            this.labelSAA.TabIndex = 1;
            this.labelSAA.Text = "Location of SAA/E";
            // 
            // textBoxSAA
            // 
            this.textBoxSAA.Enabled = false;
            this.textBoxSAA.Location = new System.Drawing.Point(109, 17);
            this.textBoxSAA.Name = "textBoxSAA";
            this.textBoxSAA.Size = new System.Drawing.Size(313, 20);
            this.textBoxSAA.TabIndex = 0;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // groupBoxSWPSE
            // 
            this.groupBoxSWPSE.Controls.Add(this.buttonSWPSE);
            this.groupBoxSWPSE.Controls.Add(this.labelSWPSE);
            this.groupBoxSWPSE.Controls.Add(this.textBoxSWPSE);
            this.groupBoxSWPSE.Enabled = false;
            this.groupBoxSWPSE.Location = new System.Drawing.Point(12, 127);
            this.groupBoxSWPSE.Name = "groupBoxSWPSE";
            this.groupBoxSWPSE.Size = new System.Drawing.Size(531, 51);
            this.groupBoxSWPSE.TabIndex = 6;
            this.groupBoxSWPSE.TabStop = false;
            // 
            // buttonSWPSE
            // 
            this.buttonSWPSE.Location = new System.Drawing.Point(428, 15);
            this.buttonSWPSE.Name = "buttonSWPSE";
            this.buttonSWPSE.Size = new System.Drawing.Size(97, 23);
            this.buttonSWPSE.TabIndex = 3;
            this.buttonSWPSE.Text = "Manual browse";
            this.buttonSWPSE.UseVisualStyleBackColor = true;
            this.buttonSWPSE.Click += new System.EventHandler(this.buttonSWPSE_Click);
            // 
            // labelSWPSE
            // 
            this.labelSWPSE.AutoSize = true;
            this.labelSWPSE.Location = new System.Drawing.Point(7, 20);
            this.labelSWPSE.Name = "labelSWPSE";
            this.labelSWPSE.Size = new System.Drawing.Size(102, 13);
            this.labelSWPSE.TabIndex = 1;
            this.labelSWPSE.Text = "Location of SWPSE";
            // 
            // textBoxSWPSE
            // 
            this.textBoxSWPSE.Enabled = false;
            this.textBoxSWPSE.Location = new System.Drawing.Point(109, 17);
            this.textBoxSWPSE.Name = "textBoxSWPSE";
            this.textBoxSWPSE.Size = new System.Drawing.Size(313, 20);
            this.textBoxSWPSE.TabIndex = 0;
            // 
            // groupBoxSAGSNL
            // 
            this.groupBoxSAGSNL.Controls.Add(this.buttonSNLplus);
            this.groupBoxSAGSNL.Controls.Add(this.labelSNLplus);
            this.groupBoxSAGSNL.Controls.Add(this.textBoxSNLplus);
            this.groupBoxSAGSNL.Controls.Add(this.buttonSAGSNL);
            this.groupBoxSAGSNL.Controls.Add(this.labelSAGSNL);
            this.groupBoxSAGSNL.Controls.Add(this.textBoxSAGSNL);
            this.groupBoxSAGSNL.Enabled = false;
            this.groupBoxSAGSNL.Location = new System.Drawing.Point(12, 218);
            this.groupBoxSAGSNL.Name = "groupBoxSAGSNL";
            this.groupBoxSAGSNL.Size = new System.Drawing.Size(531, 76);
            this.groupBoxSAGSNL.TabIndex = 7;
            this.groupBoxSAGSNL.TabStop = false;
            // 
            // buttonSNLplus
            // 
            this.buttonSNLplus.Location = new System.Drawing.Point(429, 43);
            this.buttonSNLplus.Name = "buttonSNLplus";
            this.buttonSNLplus.Size = new System.Drawing.Size(97, 23);
            this.buttonSNLplus.TabIndex = 6;
            this.buttonSNLplus.Text = "Manual browse";
            this.buttonSNLplus.UseVisualStyleBackColor = true;
            this.buttonSNLplus.Click += new System.EventHandler(this.buttonSNLplus_Click);
            // 
            // labelSNLplus
            // 
            this.labelSNLplus.AutoSize = true;
            this.labelSNLplus.Location = new System.Drawing.Point(8, 48);
            this.labelSNLplus.Name = "labelSNLplus";
            this.labelSNLplus.Size = new System.Drawing.Size(84, 13);
            this.labelSNLplus.TabIndex = 5;
            this.labelSNLplus.Text = "Location of SNL";
            // 
            // textBoxSNLplus
            // 
            this.textBoxSNLplus.Enabled = false;
            this.textBoxSNLplus.Location = new System.Drawing.Point(110, 45);
            this.textBoxSNLplus.Name = "textBoxSNLplus";
            this.textBoxSNLplus.Size = new System.Drawing.Size(313, 20);
            this.textBoxSNLplus.TabIndex = 4;
            // 
            // buttonSAGSNL
            // 
            this.buttonSAGSNL.Location = new System.Drawing.Point(428, 15);
            this.buttonSAGSNL.Name = "buttonSAGSNL";
            this.buttonSAGSNL.Size = new System.Drawing.Size(97, 23);
            this.buttonSAGSNL.TabIndex = 3;
            this.buttonSAGSNL.Text = "Manual browse";
            this.buttonSAGSNL.UseVisualStyleBackColor = true;
            this.buttonSAGSNL.Click += new System.EventHandler(this.buttonSAGSNL_Click);
            // 
            // labelSAGSNL
            // 
            this.labelSAGSNL.AutoSize = true;
            this.labelSAGSNL.Location = new System.Drawing.Point(7, 20);
            this.labelSAGSNL.Name = "labelSAGSNL";
            this.labelSAGSNL.Size = new System.Drawing.Size(85, 13);
            this.labelSAGSNL.TabIndex = 1;
            this.labelSAGSNL.Text = "Location of SAG";
            // 
            // textBoxSAGSNL
            // 
            this.textBoxSAGSNL.Enabled = false;
            this.textBoxSAGSNL.Location = new System.Drawing.Point(109, 17);
            this.textBoxSAGSNL.Name = "textBoxSAGSNL";
            this.textBoxSAGSNL.Size = new System.Drawing.Size(313, 20);
            this.textBoxSAGSNL.TabIndex = 0;
            // 
            // groupBoxSNL
            // 
            this.groupBoxSNL.Controls.Add(this.buttonSNL);
            this.groupBoxSNL.Controls.Add(this.labelSNL);
            this.groupBoxSNL.Controls.Add(this.textBoxSNL);
            this.groupBoxSNL.Enabled = false;
            this.groupBoxSNL.Location = new System.Drawing.Point(12, 332);
            this.groupBoxSNL.Name = "groupBoxSNL";
            this.groupBoxSNL.Size = new System.Drawing.Size(531, 51);
            this.groupBoxSNL.TabIndex = 8;
            this.groupBoxSNL.TabStop = false;
            // 
            // buttonSNL
            // 
            this.buttonSNL.Location = new System.Drawing.Point(428, 15);
            this.buttonSNL.Name = "buttonSNL";
            this.buttonSNL.Size = new System.Drawing.Size(97, 23);
            this.buttonSNL.TabIndex = 3;
            this.buttonSNL.Text = "Manual browse";
            this.buttonSNL.UseVisualStyleBackColor = true;
            this.buttonSNL.Click += new System.EventHandler(this.buttonSNL_Click);
            // 
            // labelSNL
            // 
            this.labelSNL.AutoSize = true;
            this.labelSNL.Location = new System.Drawing.Point(7, 20);
            this.labelSNL.Name = "labelSNL";
            this.labelSNL.Size = new System.Drawing.Size(84, 13);
            this.labelSNL.TabIndex = 1;
            this.labelSNL.Text = "Location of SNL";
            // 
            // textBoxSNL
            // 
            this.textBoxSNL.Enabled = false;
            this.textBoxSNL.Location = new System.Drawing.Point(109, 17);
            this.textBoxSNL.Name = "textBoxSNL";
            this.textBoxSNL.Size = new System.Drawing.Size(313, 20);
            this.textBoxSNL.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 434);
            this.Controls.Add(this.groupBoxSNL);
            this.Controls.Add(this.groupBoxSAGSNL);
            this.Controls.Add(this.groupBoxSWPSE);
            this.Controls.Add(this.groupBoxSAA);
            this.Controls.Add(this.checkBoxEventLog);
            this.Controls.Add(this.checkBoxSNL);
            this.Controls.Add(this.checkBoxSAGSNL);
            this.Controls.Add(this.checkBoxSWPSE);
            this.Controls.Add(this.checkBoxSAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "SWIFT Error collector";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxSAA.ResumeLayout(false);
            this.groupBoxSAA.PerformLayout();
            this.groupBoxSWPSE.ResumeLayout(false);
            this.groupBoxSWPSE.PerformLayout();
            this.groupBoxSAGSNL.ResumeLayout(false);
            this.groupBoxSAGSNL.PerformLayout();
            this.groupBoxSNL.ResumeLayout(false);
            this.groupBoxSNL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxSAA;
        private System.Windows.Forms.CheckBox checkBoxSWPSE;
        private System.Windows.Forms.CheckBox checkBoxSAGSNL;
        private System.Windows.Forms.CheckBox checkBoxSNL;
        private System.Windows.Forms.CheckBox checkBoxEventLog;
        private System.Windows.Forms.GroupBox groupBoxSAA;
        private System.Windows.Forms.Button buttonSAA;
        private System.Windows.Forms.Label labelSAA;
        private System.Windows.Forms.TextBox textBoxSAA;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.GroupBox groupBoxSWPSE;
        private System.Windows.Forms.Button buttonSWPSE;
        private System.Windows.Forms.Label labelSWPSE;
        private System.Windows.Forms.TextBox textBoxSWPSE;
        private System.Windows.Forms.GroupBox groupBoxSAGSNL;
        private System.Windows.Forms.Button buttonSAGSNL;
        private System.Windows.Forms.Label labelSAGSNL;
        private System.Windows.Forms.TextBox textBoxSAGSNL;
        private System.Windows.Forms.GroupBox groupBoxSNL;
        private System.Windows.Forms.Button buttonSNL;
        private System.Windows.Forms.Label labelSNL;
        private System.Windows.Forms.TextBox textBoxSNL;
        private System.Windows.Forms.Button buttonSNLplus;
        private System.Windows.Forms.Label labelSNLplus;
        private System.Windows.Forms.TextBox textBoxSNLplus;
    }
}

