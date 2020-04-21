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
    public partial class editdriver : Form
    {
        public string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        public OracleConnection conn;
        public editdriver()
        {
            InitializeComponent();
        }
        private void editdriver_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update_driver";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("PHONE", textBox1.Text);
            cmd.Parameters.Add("USER_NAME", textBox2.Text);
            cmd.Parameters.Add("MAIL", textBox3.Text);
            cmd.Parameters.Add("PASS", textBox4.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Driver Updated");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updatecar uc = new updatecar();
            uc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "delete_driver";
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add("PHONE", textBox1.Text);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Driver Deleted");
        }
    }
}
