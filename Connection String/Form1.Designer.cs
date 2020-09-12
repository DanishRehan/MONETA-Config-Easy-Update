using System.Drawing;

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
            this.Search = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.repText = new System.Windows.Forms.TextBox();
            this.msgText = new System.Windows.Forms.Label();
            this.repLabel = new System.Windows.Forms.Label();
            this.regCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xmlCombo = new System.Windows.Forms.ComboBox();
            this.exText = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.webSearch = new System.Windows.Forms.Button();
            this.firstPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.secondPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.thirdPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.serviceSearch = new System.Windows.Forms.Button();
            this.fourthPanel = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.moneta = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstPanel.SuspendLayout();
            this.secondPanel.SuspendLayout();
            this.thirdPanel.SuspendLayout();
            this.fourthPanel.SuspendLayout();
            this.header.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(67, 66);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(100, 23);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search IIS";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Button1_Click);
            this.Search.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton1);
            this.Search.MouseHover += new System.EventHandler(this.OnMouseEnterButton1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(638, 50);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update All";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.Rep_Click);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton1);
            this.btnUpdate.MouseHover += new System.EventHandler(this.OnMouseEnterButton1);
            // 
            // repText
            // 
            this.repText.Location = new System.Drawing.Point(257, 51);
            this.repText.Name = "repText";
            this.repText.Size = new System.Drawing.Size(375, 20);
            this.repText.TabIndex = 3;
            // 
            // msgText
            // 
            this.msgText.AutoSize = true;
            this.msgText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgText.ForeColor = System.Drawing.Color.Green;
            this.msgText.Location = new System.Drawing.Point(322, 126);
            this.msgText.Name = "msgText";
            this.msgText.Size = new System.Drawing.Size(191, 16);
            this.msgText.TabIndex = 4;
            this.msgText.Text = "Tags have been replaced!";
            this.msgText.Visible = false;
            // 
            // repLabel
            // 
            this.repLabel.AutoSize = true;
            this.repLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repLabel.ForeColor = System.Drawing.Color.Lavender;
            this.repLabel.Location = new System.Drawing.Point(122, 55);
            this.repLabel.Name = "repLabel";
            this.repLabel.Size = new System.Drawing.Size(115, 16);
            this.repLabel.TabIndex = 6;
            this.repLabel.Text = "Replace Value:";
            // 
            // regCheckBox
            // 
            this.regCheckBox.AutoSize = true;
            this.regCheckBox.ForeColor = System.Drawing.Color.Lavender;
            this.regCheckBox.Location = new System.Drawing.Point(473, 21);
            this.regCheckBox.Name = "regCheckBox";
            this.regCheckBox.Size = new System.Drawing.Size(107, 17);
            this.regCheckBox.TabIndex = 7;
            this.regCheckBox.Text = "Replace Registry";
            this.regCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(122, 23);
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
            "URLWS",
            "IRISwebServiceurl",
            "BaseAddress",
            "IRISWebServiceURL",
            "IRISGatewayURL",
            "HostBankIMD",
            "HostBankCode",
            "HostBankName",
            "HostBankShortCode",
            "TPAML_ApiURL",
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
            this.xmlCombo.Location = new System.Drawing.Point(257, 18);
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
            this.exText.Location = new System.Drawing.Point(20, 85);
            this.exText.Name = "exText";
            this.exText.Size = new System.Drawing.Size(0, 13);
            this.exText.TabIndex = 10;
            this.exText.Visible = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(46, 98);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(143, 94);
            this.checkedListBox1.TabIndex = 13;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // webSearch
            // 
            this.webSearch.Location = new System.Drawing.Point(67, 214);
            this.webSearch.Name = "webSearch";
            this.webSearch.Size = new System.Drawing.Size(100, 23);
            this.webSearch.TabIndex = 14;
            this.webSearch.Text = "Search for Config";
            this.webSearch.UseVisualStyleBackColor = true;
            this.webSearch.Click += new System.EventHandler(this.btnRefresh_Click);
            this.webSearch.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton1);
            this.webSearch.MouseHover += new System.EventHandler(this.OnMouseEnterButton1);
            // 
            // firstPanel
            // 
            this.firstPanel.BackColor = System.Drawing.Color.SlateGray;
            this.firstPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstPanel.Controls.Add(this.label5);
            this.firstPanel.Controls.Add(this.label3);
            this.firstPanel.Controls.Add(this.label1);
            this.firstPanel.Controls.Add(this.Search);
            this.firstPanel.Controls.Add(this.webSearch);
            this.firstPanel.Controls.Add(this.checkedListBox1);
            this.firstPanel.Location = new System.Drawing.Point(2, 98);
            this.firstPanel.Name = "firstPanel";
            this.firstPanel.Size = new System.Drawing.Size(235, 293);
            this.firstPanel.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(101, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "IIS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Lavender;
            this.label3.Location = new System.Drawing.Point(7, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Search for Config files in the selected website";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Select hosted Moneta website";
            // 
            // secondPanel
            // 
            this.secondPanel.BackColor = System.Drawing.Color.SlateGray;
            this.secondPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondPanel.Controls.Add(this.label4);
            this.secondPanel.Location = new System.Drawing.Point(236, 98);
            this.secondPanel.Name = "secondPanel";
            this.secondPanel.Size = new System.Drawing.Size(369, 293);
            this.secondPanel.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(108, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Configuration Files";
            // 
            // thirdPanel
            // 
            this.thirdPanel.BackColor = System.Drawing.Color.SlateGray;
            this.thirdPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thirdPanel.Controls.Add(this.label6);
            this.thirdPanel.Controls.Add(this.serviceSearch);
            this.thirdPanel.Location = new System.Drawing.Point(601, 98);
            this.thirdPanel.Name = "thirdPanel";
            this.thirdPanel.Size = new System.Drawing.Size(235, 293);
            this.thirdPanel.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(44, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Windows Services";
            // 
            // serviceSearch
            // 
            this.serviceSearch.Location = new System.Drawing.Point(67, 131);
            this.serviceSearch.Name = "serviceSearch";
            this.serviceSearch.Size = new System.Drawing.Size(100, 23);
            this.serviceSearch.TabIndex = 0;
            this.serviceSearch.Text = "Search for Config";
            this.serviceSearch.UseVisualStyleBackColor = true;
            this.serviceSearch.Click += new System.EventHandler(this.serviceSearch_Click);
            this.serviceSearch.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton1);
            this.serviceSearch.MouseHover += new System.EventHandler(this.OnMouseEnterButton1);
            // 
            // fourthPanel
            // 
            this.fourthPanel.BackColor = System.Drawing.Color.SlateGray;
            this.fourthPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fourthPanel.Controls.Add(this.msgText);
            this.fourthPanel.Controls.Add(this.exText);
            this.fourthPanel.Controls.Add(this.btnUpdate);
            this.fourthPanel.Controls.Add(this.repText);
            this.fourthPanel.Controls.Add(this.repLabel);
            this.fourthPanel.Controls.Add(this.regCheckBox);
            this.fourthPanel.Controls.Add(this.xmlCombo);
            this.fourthPanel.Controls.Add(this.label2);
            this.fourthPanel.Location = new System.Drawing.Point(2, 388);
            this.fourthPanel.Name = "fourthPanel";
            this.fourthPanel.Size = new System.Drawing.Size(834, 156);
            this.fourthPanel.TabIndex = 18;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Gray;
            this.header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.header.Controls.Add(this.moneta);
            this.header.Controls.Add(this.menuStrip1);
            this.header.Location = new System.Drawing.Point(2, -3);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(834, 105);
            this.header.TabIndex = 19;
            // 
            // moneta
            // 
            this.moneta.AutoSize = true;
            this.moneta.Font = new System.Drawing.Font("Forte", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneta.ForeColor = System.Drawing.SystemColors.Control;
            this.moneta.Location = new System.Drawing.Point(164, 31);
            this.moneta.Name = "moneta";
            this.moneta.Size = new System.Drawing.Size(505, 41);
            this.moneta.TabIndex = 0;
            this.moneta.Text = "MONETA Config Easy Update";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(835, 542);
            this.Controls.Add(this.header);
            this.Controls.Add(this.fourthPanel);
            this.Controls.Add(this.thirdPanel);
            this.Controls.Add(this.firstPanel);
            this.Controls.Add(this.secondPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MONETA Config Easy Update - TPS - Danish Rehan";
            this.firstPanel.ResumeLayout(false);
            this.firstPanel.PerformLayout();
            this.secondPanel.ResumeLayout(false);
            this.secondPanel.PerformLayout();
            this.thirdPanel.ResumeLayout(false);
            this.thirdPanel.PerformLayout();
            this.fourthPanel.ResumeLayout(false);
            this.fourthPanel.PerformLayout();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox repText;
        private System.Windows.Forms.Label msgText;
        private System.Windows.Forms.Label repLabel;
        private System.Windows.Forms.CheckBox regCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox xmlCombo;
        private System.Windows.Forms.Label exText;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button webSearch;
        private System.Windows.Forms.Panel firstPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel secondPanel;
        private System.Windows.Forms.Panel thirdPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button serviceSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel fourthPanel;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label moneta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

