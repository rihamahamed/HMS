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
    public partial class frm_reinn : Form
    {
        public frm_reinn()
        {
            InitializeComponent();
        }

        private void frm_reinn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet5.Innovice' table. You can move, or remove it, as needed.
            this.innoviceTableAdapter.Fill(this.hMSDataSet5.Innovice);
            // TODO: This line of code loads data into the 'hMSDataSet4.Innovice' table. You can move, or remove it, as needed.
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
