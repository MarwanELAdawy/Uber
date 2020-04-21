using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace Uber
{
    public partial class Report_Driver : Form
    {
        parameters cr;
        public Report_Driver()
        {
            InitializeComponent();
            cr = new parameters();
            foreach (ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues)
            {
                comboBox1.Items.Add(v.Value);
            }
        }
        private void Report_Driver_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
