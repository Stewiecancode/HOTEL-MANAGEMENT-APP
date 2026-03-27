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
    public partial class Form2 : Form
    {
        string connectionstring = @"Data Source=DESKTOP-TSHIRE\SQLEXPRESS02;Initial Catalog=DataBase;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //logs out of the system
            Form1 f = new Form1();
            f.Show();
            this.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //closes the form or application
            Environment.Exit(0);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

            SqlConnection sqlconn = new SqlConnection(connectionstring );
            sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand("select * from Area ");
            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            //connects the ide with server
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            //opnes the connection
            sqlcon.Open();
            SqlCommand sqlcmd = sqlcon.CreateCommand();
            //fecthes the data that  is only needed or selcted
            sqlcmd.CommandText = "select * from Area where Name='" + txtsearch.Text + "'";
            SqlDataAdapter sqlda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            //fills the data in the data table
            sqlda.Fill(dt);
            //fills the data with information
            dataGridView1.DataSource = dt;
            sqlcon.Close();
        }
    }
}
