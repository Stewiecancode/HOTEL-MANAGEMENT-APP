using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session_4_coding
{
    public partial class Form1 : Form
    {
        string connectionstring = @"Data Source=DESKTOP-TSHIRE\SQLEXPRESS02;Initial Catalog=DataBase;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNLOGIN_Click(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection(connectionstring );
            SqlCommand sqlcommand = new SqlCommand("select Username,Password from Users where Username = @Username and Password = @Password",sqlcon );
            sqlcommand.Parameters.AddWithValue("@Username", TXTUSER.Text);
            sqlcommand.Parameters.AddWithValue("@Password", TXTPASSWORD.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcommand );
            sda.SelectCommand = sqlcommand;
            sda.Fill(dt);

            if (dt.Rows.Count >0) 
            {
                MessageBox.Show("login successful !!!");
                Form2 f = new Form2();
                f.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("login unsuccessful !!");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TXTPASSWORD.PasswordChar = '*';
        }

        private void chkshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshowpassword.Checked ) 
            {
                TXTPASSWORD.PasswordChar = '\0';
            }
            else 
            {
                TXTPASSWORD.PasswordChar = '*';
            }
        }

        private void llblcreateaccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
