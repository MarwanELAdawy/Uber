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
    public partial class Trip : Form
    {
        public string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        public OracleConnection conn;
        public int c, c1, c2, res;
        public static int driverphone;
        public static int TripID;
        public Trip()
        {
            InitializeComponent();
        }

        private void Trip_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from cities";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
                comboBox2.Items.Add(dr[0]);
            }
            dr.Close();
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "alldrivers";
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add("dest", OracleDbType.RefCursor,ParameterDirection.Output);
            OracleDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox3.Items.Add(dr2[0]);
            }
            dr2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != null || comboBox2.Text != null || comboBox3.Text != null)
            {
                if (comboBox1.Text == comboBox2.Text)
                {
                    MessageBox.Show("please try again");
                }
                else
                {
                    conn = new OracleConnection(ordb);
                    conn.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Select bl7 from cities where name =:n";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("n", comboBox1.Text);
                    OracleDataReader dr3 = cmd.ExecuteReader();
                    while (dr3.Read())
                    {
                        c = int.Parse(dr3[0].ToString());
                    }
                    dr3.Close();

                    OracleCommand cmd1 = new OracleCommand();
                    cmd1.Connection = conn;
                    cmd1.CommandText = "Select bl7 from cities where name =:n";
                    cmd1.CommandType = CommandType.Text;
                    cmd1.Parameters.Add("n", comboBox2.Text);
                    OracleDataReader dr4 = cmd1.ExecuteReader();
                    while (dr4.Read())
                    {
                        c1 = int.Parse(dr4[0].ToString());
                    }
                    dr4.Close();

                    OracleCommand cm = new OracleCommand();
                    cm.Connection = conn;
                    cm.CommandText = "select count(*) from trip";
                    cm.CommandType = CommandType.Text;
                    OracleDataReader dr = cm.ExecuteReader();
                    if (dr.Read())
                    {
                        c2 = int.Parse(dr[0].ToString());

                    }
                    dr.Close();


                    res = c - c1;
                    if (res < 0)
                        res *= -1;
                    TripID= c2 + 1;
                    string clint_phone = Welcome.phoneclient;
                    string rate = null;
                    OracleCommand cmd2 = new OracleCommand();
                    cmd2.Connection = conn;
                    cmd2.CommandText = "insert into TRIP values (:trip_id,:trip_cost,:start_loc,:end_loc,:c_phone,:d_phone,:rate)";
                    cmd2.Parameters.Add("trip_id", c2 + 1);
                    cmd2.Parameters.Add("trip_cost", res*10);
                    cmd2.Parameters.Add("start_loc", comboBox1.Text);
                    cmd2.Parameters.Add("end_loc", comboBox2.Text);
                    cmd2.Parameters.Add("c_phone", clint_phone);
                    cmd2.Parameters.Add("d_phone", comboBox3.Text);
                    cmd2.Parameters.Add("rate",rate);
                    int r = cmd2.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("Trip is done");
                    }
                    driverphone = int.Parse( comboBox3.Text);
                    this.Hide();
                    Rate us = new Rate();
                    us.Show();



                }
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
