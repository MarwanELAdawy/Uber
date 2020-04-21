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
    public partial class RegisterDriver : Form
    {
        public string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        public OracleConnection conn;
        public RegisterDriver()
        {
            InitializeComponent();
        }
        private void RegisterDriver_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Insert_Driver";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("phone", textBox2.Text);
            cmd.Parameters.Add("USER_NAME", textBox1.Text);
            cmd.Parameters.Add("mail", textBox3.Text);
            cmd.Parameters.Add("pass", textBox4.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Driver Added");
            this.Hide();
            Welcome w = new Welcome();
            w.Show();
        }

    }
}
