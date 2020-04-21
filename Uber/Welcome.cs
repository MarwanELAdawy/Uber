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

    public partial class Welcome : Form
    {
        public static string phoneDriver = "";
        public static string phoneclient = "";
        public string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        public OracleConnection conn;
        public Welcome()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool fola = true;
            if(comboBox1.Text == "Client")
            {
                if (textBox1.Text!=null&&textBox2.Text!=null)
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Select phone from client where phone =:p and pass =:bl7";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("p", textBox1.Text);
                    cmd.Parameters.Add("bl7", textBox2.Text);
                    OracleDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        if (textBox1.Text == dr[0].ToString())
                            fola = false;
                    }
                    dr.Close();
                    if (!fola)
                    {
                        this.Hide();
                        phoneclient = textBox1.Text;
                        Userpanel f2 = new Userpanel();
                        f2.Show();
                    }
                }
            }
            else if(comboBox1.Text == "Driver")
            {
                if (textBox1.Text != null && textBox2.Text != null)
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Select phone from driver where phone =:p and pass =:bl7";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("p", textBox1.Text);
                    cmd.Parameters.Add("bl7", textBox2.Text);
                    OracleDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        if (textBox1.Text == dr[0].ToString())
                            fola = false;
                    }
                    dr.Close();
                    if (!fola)
                    {
                        phoneDriver = textBox1.Text;
                        this.Hide();
                        DriverForm df = new DriverForm();
                        df.Show();
                    }
                }
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Client")
            {
                Register f = new Register();
                f.Show();
                Welcome f1 = new Welcome();
                f1.Hide();
            }
            else if(comboBox1.Text == "Driver")
            {
                RegisterDriver rd = new RegisterDriver();
                rd.Show();
            }
        }
    }
}
