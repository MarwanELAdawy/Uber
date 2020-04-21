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
    public partial class DriverForm : Form
    {
        public string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        public OracleConnection conn;
        public static int rate;
        public DriverForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            editdriver ed = new editdriver();
            ed.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            updatecar uc = new updatecar();
            uc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            triphistory ts = new triphistory();
            ts.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select rate from driver where phone =:p";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("p",Welcome.phoneDriver);
            OracleDataReader dr = cmd.ExecuteReader();
            string var = "";
            if (dr.Read())
            {
               var = dr[0].ToString();
            }
            
            MessageBox.Show(var);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Report_Driver rd = new Report_Driver();
            rd.Show();
            this.Hide();
        }
    }
}
