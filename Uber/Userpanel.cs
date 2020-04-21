using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uber
{
    public partial class Userpanel : Form
    {
        public Userpanel()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditInfo ei = new EditInfo();
            ei.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trip t = new Trip();
            t.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            client_history ch = new client_history();
                ch.Show();
        }
    }
}
