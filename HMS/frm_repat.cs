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
    public partial class frm_repat : Form
    {
        public frm_repat()
        {
            InitializeComponent();
        }

        private void frm_repat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet1.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.hMSDataSet1.Patient);

        }
    }
}
