using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Uber
{
    public partial class EditInfo : Form
    {
        public string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        public OracleConnection conn;
        private void EditInfo_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
        public EditInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update client set PHONE=:phone, USER_NAME=:name , LOCATION=:address , MAIL=:email , PASS=:pass where Phone =:phone";

            cmd.Parameters.Add("phone", textBox2.Text);
            cmd.Parameters.Add("name", textBox1.Text);
            cmd.Parameters.Add("address", textBox5.Text);
            cmd.Parameters.Add("email", textBox3.Text);
            cmd.Parameters.Add("pass", textBox4.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Client modified");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "Delete from trip where C_PHONE=:phone";
            c.Parameters.Add("phone", textBox2.Text);
            c.ExecuteNonQuery();
            OracleCommand c2 = new OracleCommand();
            c2.Connection = conn;
            c2.CommandText = "Delete from Client where PHONE=:phone";
            c2.Parameters.Add("phone", textBox2.Text);
            int r = c2.ExecuteNonQuery();

            if (r != -1)
            {
                MessageBox.Show("Account deleted");
            }


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
