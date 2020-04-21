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
    public partial class client_history : Form
    {
        public string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        string cmdstr = "select * from trip where C_PHONE =:dp";
        public OracleConnection conn;
        OracleDataAdapter adapter;
        DataSet ds = new DataSet();

        public client_history()
        {
            InitializeComponent();
        }

        private void client_history_Load(object sender, EventArgs e)
        {
            adapter = new OracleDataAdapter(cmdstr, ordb);
            adapter.SelectCommand.Parameters.Add("dp", Welcome.phoneclient);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
