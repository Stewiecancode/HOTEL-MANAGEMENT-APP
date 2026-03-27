
namespace session_4_coding
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.txtretypepassword = new System.Windows.Forms.TextBox();
            this.radmale = new System.Windows.Forms.RadioButton();
            this.radfemale = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Btnregister = new System.Windows.Forms.Button();
            this.dudfamilycount = new System.Windows.Forms.DomainUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.chkterms = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birthday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Retype Password:";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(114, 42);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(130, 22);
            this.txtusername.TabIndex = 5;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(114, 223);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(130, 22);
            this.txtpassword.TabIndex = 6;
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(114, 98);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(130, 22);
            this.txtfullname.TabIndex = 8;
            // 
            // txtretypepassword
            // 
            this.txtretypepassword.Location = new System.Drawing.Point(433, 223);
            this.txtretypepassword.Name = "txtretypepassword";
            this.txtretypepassword.Size = new System.Drawing.Size(130, 22);
            this.txtretypepassword.TabIndex = 9;
            // 
            // radmale
            // 
            this.radmale.AutoSize = true;
            this.radmale.Location = new System.Drawing.Point(308, 47);
            this.radmale.Name = "radmale";
            this.radmale.Size = new System.Drawing.Size(59, 21);
            this.radmale.TabIndex = 10;
            this.radmale.TabStop = true;
            this.radmale.Text = "Male";
            this.radmale.UseVisualStyleBackColor = true;
            this.radmale.CheckedChanged += new System.EventHandler(this.radmale_CheckedChanged);
            // 
            // radfemale
            // 
            this.radfemale.AutoSize = true;
            this.radfemale.Location = new System.Drawing.Point(453, 47);
            this.radfemale.Name = "radfemale";
            this.radfemale.Size = new System.Drawing.Size(75, 21);
            this.radfemale.TabIndex = 11;
            this.radfemale.TabStop = true;
            this.radfemale.Text = "Female";
            this.radfemale.UseVisualStyleBackColor = true;
            this.radfemale.CheckedChanged += new System.EventHandler(this.radfemale_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/mm/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 156);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // Btnregister
            // 
            this.Btnregister.Location = new System.Drawing.Point(216, 344);
            this.Btnregister.Name = "Btnregister";
            this.Btnregister.Size = new System.Drawing.Size(172, 42);
            this.Btnregister.TabIndex = 13;
            this.Btnregister.Text = "Register";
            this.Btnregister.UseVisualStyleBackColor = true;
            this.Btnregister.Click += new System.EventHandler(this.Btnregister_Click);
            // 
            // dudfamilycount
            // 
            this.dudfamilycount.Items.Add("1");
            this.dudfamilycount.Items.Add("2");
            this.dudfamilycount.Items.Add("3");
            this.dudfamilycount.Items.Add("4");
            this.dudfamilycount.Items.Add("5");
            this.dudfamilycount.Items.Add("6");
            this.dudfamilycount.Items.Add("7");
            this.dudfamilycount.Items.Add("8");
            this.dudfamilycount.Items.Add("9");
            this.dudfamilycount.Items.Add("10");
            this.dudfamilycount.Items.Add("11");
            this.dudfamilycount.Items.Add("12");
            this.dudfamilycount.Items.Add("13");
            this.dudfamilycount.Items.Add("14");
            this.dudfamilycount.Items.Add("15");
            this.dudfamilycount.Items.Add("16");
            this.dudfamilycount.Items.Add("17");
            this.dudfamilycount.Items.Add("18");
            this.dudfamilycount.Items.Add("19");
            this.dudfamilycount.Items.Add("20");
            this.dudfamilycount.Items.Add("21");
            this.dudfamilycount.Items.Add("21");
            this.dudfamilycount.Items.Add("22");
            this.dudfamilycount.Items.Add("23");
            this.dudfamilycount.Items.Add("24");
            this.dudfamilycount.Items.Add("25");
            this.dudfamilycount.Items.Add("26");
            this.dudfamilycount.Items.Add("27");
            this.dudfamilycount.Items.Add("28");
            this.dudfamilycount.Items.Add("29");
            this.dudfamilycount.Items.Add("30");
            this.dudfamilycount.Location = new System.Drawing.Point(436, 169);
            this.dudfamilycount.Name = "dudfamilycount";
            this.dudfamilycount.Size = new System.Drawing.Size(44, 22);
            this.dudfamilycount.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Number of Family ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(436, 304);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 17);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // chkterms
            // 
            this.chkterms.AutoSize = true;
            this.chkterms.Location = new System.Drawing.Point(103, 304);
            this.chkterms.Name = "chkterms";
            this.chkterms.Size = new System.Drawing.Size(207, 21);
            this.chkterms.TabIndex = 17;
            this.chkterms.Text = "accept terms and conditions";
            this.chkterms.UseVisualStyleBackColor = true;
            this.chkterms.CheckedChanged += new System.EventHandler(this.chkterms_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(595, 417);
            this.Controls.Add(this.chkterms);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dudfamilycount);
            this.Controls.Add(this.Btnregister);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radfemale);
            this.Controls.Add(this.radmale);
            this.Controls.Add(this.txtretypepassword);
            this.Controls.Add(this.txtfullname);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.TextBox txtretypepassword;
        private System.Windows.Forms.RadioButton radmale;
        private System.Windows.Forms.RadioButton radfemale;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Btnregister;
        private System.Windows.Forms.DomainUpDown dudfamilycount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox chkterms;
    }
}