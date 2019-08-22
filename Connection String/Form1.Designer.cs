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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reg = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(460, 255);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 0;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pathText
            // 
            this.pathText.Location = new System.Drawing.Point(169, 257);
            this.pathText.Name = "pathText";
            this.pathText.Size = new System.Drawing.Size(262, 20);
            this.pathText.TabIndex = 1;
            // 
            // rep
            // 
            this.rep.Location = new System.Drawing.Point(460, 306);
            this.rep.Name = "rep";
            this.rep.Size = new System.Drawing.Size(75, 23);
            this.rep.TabIndex = 2;
            this.rep.Text = "Replace All";
            this.rep.UseVisualStyleBackColor = true;
            this.rep.Click += new System.EventHandler(this.Rep_Click);
            // 
            // repText
            // 
            this.repText.Location = new System.Drawing.Point(169, 306);
            this.repText.Name = "repText";
            this.repText.Size = new System.Drawing.Size(262, 20);
            this.repText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Directory:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Replace With:";
            // 
            // reg
            // 
            this.reg.AutoSize = true;
            this.reg.Location = new System.Drawing.Point(559, 311);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(107, 17);
            this.reg.TabIndex = 7;
            this.reg.Text = "Replace Registry";
            this.reg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox reg;
    }
}

