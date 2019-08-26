namespace Connection_String
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
            this.browse = new System.Windows.Forms.Button();
            this.pathText = new System.Windows.Forms.TextBox();
            this.rep = new System.Windows.Forms.Button();
            this.repText = new System.Windows.Forms.TextBox();
            this.msgText = new System.Windows.Forms.Label();
            this.dirLabel = new System.Windows.Forms.Label();
            this.repLabel = new System.Windows.Forms.Label();
            this.regCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xmlCombo = new System.Windows.Forms.ComboBox();
            this.exText = new System.Windows.Forms.Label();
            this.radioWeb = new System.Windows.Forms.RadioButton();
            this.radioWin = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(638, 255);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 0;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pathText
            // 
            this.pathText.Location = new System.Drawing.Point(257, 257);
            this.pathText.Name = "pathText";
            this.pathText.ReadOnly = true;
            this.pathText.Size = new System.Drawing.Size(375, 20);
            this.pathText.TabIndex = 1;
            // 
            // rep
            // 
            this.rep.Location = new System.Drawing.Point(638, 321);
            this.rep.Name = "rep";
            this.rep.Size = new System.Drawing.Size(75, 23);
            this.rep.TabIndex = 2;
            this.rep.Text = "Replace All";
            this.rep.UseVisualStyleBackColor = true;
            this.rep.Click += new System.EventHandler(this.Rep_Click);
            // 
            // repText
            // 
            this.repText.Location = new System.Drawing.Point(257, 322);
            this.repText.Name = "repText";
            this.repText.Size = new System.Drawing.Size(375, 20);
            this.repText.TabIndex = 3;
            // 
            // msgText
            // 
            this.msgText.AutoSize = true;
            this.msgText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgText.ForeColor = System.Drawing.Color.Green;
            this.msgText.Location = new System.Drawing.Point(322, 393);
            this.msgText.Name = "msgText";
            this.msgText.Size = new System.Drawing.Size(191, 16);
            this.msgText.TabIndex = 4;
            this.msgText.Text = "Tags have been replaced!";
            this.msgText.Visible = false;
            // 
            // dirLabel
            // 
            this.dirLabel.AutoSize = true;
            this.dirLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirLabel.Location = new System.Drawing.Point(122, 261);
            this.dirLabel.Name = "dirLabel";
            this.dirLabel.Size = new System.Drawing.Size(75, 16);
            this.dirLabel.TabIndex = 5;
            this.dirLabel.Text = "Directory:";
            // 
            // repLabel
            // 
            this.repLabel.AutoSize = true;
            this.repLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repLabel.Location = new System.Drawing.Point(122, 326);
            this.repLabel.Name = "repLabel";
            this.repLabel.Size = new System.Drawing.Size(115, 16);
            this.repLabel.TabIndex = 6;
            this.repLabel.Text = "Replace Value:";
            // 
            // regCheckBox
            // 
            this.regCheckBox.AutoSize = true;
            this.regCheckBox.Location = new System.Drawing.Point(402, 292);
            this.regCheckBox.Name = "regCheckBox";
            this.regCheckBox.Size = new System.Drawing.Size(107, 17);
            this.regCheckBox.TabIndex = 7;
            this.regCheckBox.Text = "Replace Registry";
            this.regCheckBox.UseVisualStyleBackColor = true;
            this.regCheckBox.CheckedChanged += new System.EventHandler(this.RegCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "XML Key:";
            // 
            // xmlCombo
            // 
            this.xmlCombo.FormattingEnabled = true;
            this.xmlCombo.Items.AddRange(new object[] {
            "ConnString",
            "HostBankIMD",
            "HostBankCode",
            "HostBankName",
            "HostBankShortCode",
            "drives",
            "drivesRejdir",
            "driveExport",
            "defaultExpPath",
            "driveFeedBack",
            "driveDisbursement",
            "driveExpiredTransation",
            "drivePassedFile",
            "driveFailedFile",
            "driveCSVFile",
            "defaultcsvPath",
            "defaultPassDir",
            "defaultFailDir",
            "defaultRTGSDir",
            "defaultRTGSDirAfterApend"});
            this.xmlCombo.Location = new System.Drawing.Point(257, 289);
            this.xmlCombo.Name = "xmlCombo";
            this.xmlCombo.Size = new System.Drawing.Size(138, 21);
            this.xmlCombo.TabIndex = 9;
            this.xmlCombo.SelectedIndexChanged += new System.EventHandler(this.XmlCombo_SelectedIndexChanged);
            // 
            // exText
            // 
            this.exText.AutoSize = true;
            this.exText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exText.ForeColor = System.Drawing.Color.Red;
            this.exText.Location = new System.Drawing.Point(12, 358);
            this.exText.Name = "exText";
            this.exText.Size = new System.Drawing.Size(54, 13);
            this.exText.TabIndex = 10;
            this.exText.Text = "Exception";
            this.exText.Visible = false;
            // 
            // radioWeb
            // 
            this.radioWeb.AutoSize = true;
            this.radioWeb.Location = new System.Drawing.Point(302, 225);
            this.radioWeb.Name = "radioWeb";
            this.radioWeb.Size = new System.Drawing.Size(92, 17);
            this.radioWeb.TabIndex = 11;
            this.radioWeb.TabStop = true;
            this.radioWeb.Text = "Web Services";
            this.radioWeb.UseVisualStyleBackColor = true;
            this.radioWeb.CheckedChanged += new System.EventHandler(this.RadioWeb_CheckedChanged);
            // 
            // radioWin
            // 
            this.radioWin.AutoSize = true;
            this.radioWin.Location = new System.Drawing.Point(419, 225);
            this.radioWin.Name = "radioWin";
            this.radioWin.Size = new System.Drawing.Size(113, 17);
            this.radioWin.TabIndex = 12;
            this.radioWin.TabStop = true;
            this.radioWin.Text = "Windows Services";
            this.radioWin.UseVisualStyleBackColor = true;
            this.radioWin.CheckedChanged += new System.EventHandler(this.RadioWin_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 467);
            this.Controls.Add(this.radioWin);
            this.Controls.Add(this.radioWeb);
            this.Controls.Add(this.exText);
            this.Controls.Add(this.xmlCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.regCheckBox);
            this.Controls.Add(this.repLabel);
            this.Controls.Add(this.dirLabel);
            this.Controls.Add(this.msgText);
            this.Controls.Add(this.repText);
            this.Controls.Add(this.rep);
            this.Controls.Add(this.pathText);
            this.Controls.Add(this.browse);
            this.Name = "Form1";
            this.Text = "XML String Changer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.Button rep;
        private System.Windows.Forms.TextBox repText;
        private System.Windows.Forms.Label msgText;
        private System.Windows.Forms.Label dirLabel;
        private System.Windows.Forms.Label repLabel;
        private System.Windows.Forms.CheckBox regCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox xmlCombo;
        private System.Windows.Forms.Label exText;
        private System.Windows.Forms.RadioButton radioWeb;
        private System.Windows.Forms.RadioButton radioWin;
    }
}

