
namespace session_4_coding
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTADMIN = new System.Windows.Forms.TextBox();
            this.TXTUSER = new System.Windows.Forms.TextBox();
            this.TXTPASSWORD = new System.Windows.Forms.TextBox();
            this.BTNLOGIN = new System.Windows.Forms.Button();
            this.chkshowpassword = new System.Windows.Forms.CheckBox();
            this.llblcreateaccount = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.bntexit = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.llblcreateaccount);
            this.groupBox1.Controls.Add(this.chkshowpassword);
            this.groupBox1.Controls.Add(this.BTNLOGIN);
            this.groupBox1.Controls.Add(this.TXTPASSWORD);
            this.groupBox1.Controls.Add(this.TXTUSER);
            this.groupBox1.Controls.Add(this.TXTADMIN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 428);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "USER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD";
            // 
            // TXTADMIN
            // 
            this.TXTADMIN.Location = new System.Drawing.Point(104, 135);
            this.TXTADMIN.Name = "TXTADMIN";
            this.TXTADMIN.Size = new System.Drawing.Size(427, 22);
            this.TXTADMIN.TabIndex = 3;
            // 
            // TXTUSER
            // 
            this.TXTUSER.Location = new System.Drawing.Point(104, 212);
            this.TXTUSER.Name = "TXTUSER";
            this.TXTUSER.Size = new System.Drawing.Size(427, 22);
            this.TXTUSER.TabIndex = 4;
            // 
            // TXTPASSWORD
            // 
            this.TXTPASSWORD.Location = new System.Drawing.Point(104, 294);
            this.TXTPASSWORD.Name = "TXTPASSWORD";
            this.TXTPASSWORD.Size = new System.Drawing.Size(427, 22);
            this.TXTPASSWORD.TabIndex = 5;
            // 
            // BTNLOGIN
            // 
            this.BTNLOGIN.Location = new System.Drawing.Point(247, 358);
            this.BTNLOGIN.Name = "BTNLOGIN";
            this.BTNLOGIN.Size = new System.Drawing.Size(84, 34);
            this.BTNLOGIN.TabIndex = 6;
            this.BTNLOGIN.Text = "LOGIN";
            this.BTNLOGIN.UseVisualStyleBackColor = true;
            this.BTNLOGIN.Click += new System.EventHandler(this.BTNLOGIN_Click);
            // 
            // chkshowpassword
            // 
            this.chkshowpassword.AutoSize = true;
            this.chkshowpassword.Location = new System.Drawing.Point(413, 368);
            this.chkshowpassword.Name = "chkshowpassword";
            this.chkshowpassword.Size = new System.Drawing.Size(126, 21);
            this.chkshowpassword.TabIndex = 7;
            this.chkshowpassword.Text = "show password";
            this.chkshowpassword.UseVisualStyleBackColor = true;
            this.chkshowpassword.CheckedChanged += new System.EventHandler(this.chkshowpassword_CheckedChanged);
            // 
            // llblcreateaccount
            // 
            this.llblcreateaccount.AutoSize = true;
            this.llblcreateaccount.Location = new System.Drawing.Point(113, 348);
            this.llblcreateaccount.Name = "llblcreateaccount";
            this.llblcreateaccount.Size = new System.Drawing.Size(102, 17);
            this.llblcreateaccount.TabIndex = 8;
            this.llblcreateaccount.TabStop = true;
            this.llblcreateaccount.Text = "create account";
            this.llblcreateaccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblcreateaccount_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntexit
            // 
            this.bntexit.Location = new System.Drawing.Point(391, 25);
            this.bntexit.Name = "bntexit";
            this.bntexit.Size = new System.Drawing.Size(128, 48);
            this.bntexit.TabIndex = 1;
            this.bntexit.Text = "button2";
            this.bntexit.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(116, 55);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 17);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(636, 541);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.bntexit);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTNLOGIN;
        private System.Windows.Forms.TextBox TXTPASSWORD;
        private System.Windows.Forms.TextBox TXTUSER;
        private System.Windows.Forms.TextBox TXTADMIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkshowpassword;
        private System.Windows.Forms.LinkLabel llblcreateaccount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bntexit;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

