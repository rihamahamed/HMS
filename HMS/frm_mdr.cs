using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class frm_mdr : Form
    {
        public frm_mdr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_reinn f1 = new frm_reinn();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_repat f2 = new frm_repat();
            f2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_resupp f3 = new frm_resupp();
            f3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_redru f4 = new frm_redru();
            f4.ShowDialog();
        }

        private void frm_mdr_Load(object sender, EventArgs e)
        {

        }
    }
}
