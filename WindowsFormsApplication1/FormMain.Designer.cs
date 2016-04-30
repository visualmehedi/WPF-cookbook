namespace WindowsFormsApplication1
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonAddIng = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.labelcat = new System.Windows.Forms.Label();
            this.textBoxrecname = new System.Windows.Forms.TextBox();
            this.labelrecname = new System.Windows.Forms.Label();
            this.buttonAddrec = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox);
            this.groupBox1.Controls.Add(this.buttonAddIng);
            this.groupBox1.Controls.Add(this.comboBox);
            this.groupBox1.Controls.Add(this.labelcat);
            this.groupBox1.Controls.Add(this.textBoxrecname);
            this.groupBox1.Controls.Add(this.labelrecname);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Add new receipe";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(19, 124);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(414, 156);
            this.textBox.TabIndex = 5;
            // 
            // buttonAddIng
            // 
            this.buttonAddIng.Location = new System.Drawing.Point(307, 72);
            this.buttonAddIng.Name = "buttonAddIng";
            this.buttonAddIng.Size = new System.Drawing.Size(115, 23);
            this.buttonAddIng.TabIndex = 4;
            this.buttonAddIng.Text = "Add ingredients";
            this.buttonAddIng.UseVisualStyleBackColor = true;
            this.buttonAddIng.Click += new System.EventHandler(this.buttonAddIng_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(110, 72);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(115, 21);
            this.comboBox.TabIndex = 3;
            // 
            // labelcat
            // 
            this.labelcat.AutoSize = true;
            this.labelcat.Location = new System.Drawing.Point(16, 75);
            this.labelcat.Name = "labelcat";
            this.labelcat.Size = new System.Drawing.Size(52, 13);
            this.labelcat.TabIndex = 2;
            this.labelcat.Text = "Category:";
            // 
            // textBoxrecname
            // 
            this.textBoxrecname.Location = new System.Drawing.Point(110, 27);
            this.textBoxrecname.Name = "textBoxrecname";
            this.textBoxrecname.Size = new System.Drawing.Size(323, 20);
            this.textBoxrecname.TabIndex = 1;
            // 
            // labelrecname
            // 
            this.labelrecname.AutoSize = true;
            this.labelrecname.Location = new System.Drawing.Point(16, 27);
            this.labelrecname.Name = "labelrecname";
            this.labelrecname.Size = new System.Drawing.Size(88, 13);
            this.labelrecname.TabIndex = 0;
            this.labelrecname.Text = "Name of receipe:";
            // 
            // buttonAddrec
            // 
            this.buttonAddrec.Location = new System.Drawing.Point(21, 331);
            this.buttonAddrec.Name = "buttonAddrec";
            this.buttonAddrec.Size = new System.Drawing.Size(424, 23);
            this.buttonAddrec.TabIndex = 1;
            this.buttonAddrec.Text = " Add Receipe";
            this.buttonAddrec.UseVisualStyleBackColor = true;
            this.buttonAddrec.Click += new System.EventHandler(this.buttonAddrec_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(471, 74);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(406, 277);
            this.listBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "No. of ingred";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(640, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(714, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Description";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 366);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.buttonAddrec);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = " Apu’s Cook Book";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonAddIng;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label labelcat;
        private System.Windows.Forms.TextBox textBoxrecname;
        private System.Windows.Forms.Label labelrecname;
        private System.Windows.Forms.Button buttonAddrec;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

