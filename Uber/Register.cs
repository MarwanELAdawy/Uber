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
    public partial class Register : Form
    {
        public string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        public OracleConnection conn;
        private void Form4_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into client values (:phone,:name,:address,:email,:pass)";
            cmd.Parameters.Add("phone", textBox2.Text);
            cmd.Parameters.Add("name", textBox1.Text);
            cmd.Parameters.Add("address", textBox5.Text);
            cmd.Parameters.Add("email", textBox3.Text);
            cmd.Parameters.Add("pass", textBox4.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("New Client is added");
            }

        }

    }
}
