using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session_4_coding
{
    public partial class Form3 : Form
    {
        //declaring the connection
        string connectionstring = @"Data Source=DESKTOP-TSHIRE\SQLEXPRESS02;Initial Catalog=DataBase;Integrated Security=True";
        string gender;
        bool linklablee = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void Btnregister_Click(object sender, EventArgs e)
        {
            //declaring 
            string Male = "Male";
            string Female = "Female";

            //connecting to a sql server
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            //we opne the connetion
            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand(@"INSERT INTO [dbo].[Users]([GUID],[UserTypeID],[Username],[Password],[FullName],[Gender],[BirthDate],[FamilyCount])
                                               VALUES('"+txtusername.Text +"','"+txtpassword.Text +"','"+txtfullname.Text +"','"+gender +"','"+dateTimePicker1.Value.ToString()+"'," +
                                               "'"+dudfamilycount.Text.ToString()+"')",sqlcon);
            sqlcmd.ExecuteNonQuery();

            //validates wherether the password textboxes are equal
            if (txtpassword.Text != txtretypepassword.Text) 
            {
                txtpassword.BackColor = Color.Red;
                txtretypepassword.BackColor = Color.Red;
                MessageBox.Show("please make sure that the passwords are the same!!");
            }
            else 
            //changes the color back to white 
            {
                txtpassword.BackColor = Color.White;
                txtpassword.BackColor = Color.White;
            }

            //checks if the use agreed to the terms and conditions
            if (chkterms.Checked = false) 
            {
                MessageBox.Show("pls agree with the terms and conditions");
            }

            //shows a success massage and displays another form
            else 
            {
                MessageBox.Show("data saved susscessfully");
                Form2 f = new Form2();
                f.Show();
                this.Hide();
            }
            //close the connection
            sqlcon.Close();
        }

        private void chkterms_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //checks wherether the user read the terms
            if (!linklablee) 
            {
                MessageBox.Show("you have to read the terms and condition !!");
            }
            else 
            {
                string filepath = @"C: \Users\TSHIRELETSO\Downloads\ITSSB 2023 Nat Comp -Test Proj for training\ITSSB 2023 Nat Comp - Training TP\Resources\WSZA2024NC_TP09_Session1\Terms.txt";
                var filecontent = File.ReadAllText(filepath);
                MessageBox.Show(filecontent);
                linklablee = true;
            }
        }

        private void radmale_CheckedChanged(object sender, EventArgs e)
        {
            //assigns the gender MALE when the radiobox is clicked
            gender = "Male";
        }

        private void radfemale_CheckedChanged(object sender, EventArgs e)
        {
            //assigns the gender MALE when the radiobox is clicked
            gender = "Female";
        }
    }
}
