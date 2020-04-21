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
    
    public partial class updatecar : Form
    {
        public string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        string cmdstr = "select * from car where DRIVER_PHONE =:dp";
        public OracleConnection conn;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds = new DataSet();



        public updatecar()
        {
            InitializeComponent();
        }
        private void updatecar_Load(object sender, EventArgs e)
        {
            adapter = new OracleDataAdapter(cmdstr,ordb);
            adapter.SelectCommand.Parameters.Add("dp",Welcome.phoneDriver);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

    }
}
