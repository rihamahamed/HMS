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
    public partial class frm_mnu : Form
    {
        public frm_mnu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_innovice f1 = new frm_innovice();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_patient f2 = new frm_patient();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_Supplier f4 = new frm_Supplier();
            f4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_drugs f5 = new frm_drugs();
            f5.ShowDialog();
        }

        private void frm_mnu_Load(object sender, EventArgs e)
        {

        }
    }
}
