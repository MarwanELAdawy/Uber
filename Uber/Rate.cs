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
    public partial class Rate : Form
    {
        public string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        public OracleConnection conn;
        int TRIP = Trip.TripID;
        int driverphone = Trip.driverphone;
        int rate;
        public Rate()
        {
            InitializeComponent();
        }
        private void Rate_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update_Rate";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("RID", textBox1.Text);
            cmd.Parameters.Add("tripid", TRIP);
            cmd.ExecuteNonQuery();

            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "getAllRate";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.Add("sumRate", OracleDbType.Int32, ParameterDirection.Output);
            cm.Parameters.Add("dphone", driverphone);
            cm.ExecuteNonQuery();
            rate = int.Parse(cm.Parameters["sumRate"].Value.ToString());

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "Update_DriverRate";
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add("ratevalue",rate);
            cmd2.Parameters.Add("phonedriver", driverphone);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Thank You");
            Userpanel up = new Userpanel();
            up.Show();
            this.Hide();
        }

    }
}
