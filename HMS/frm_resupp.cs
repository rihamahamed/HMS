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
    public partial class frm_resupp : Form
    {
        public frm_resupp()
        {
            InitializeComponent();
        }

        private void frm_resupp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet2.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.hMSDataSet2.Supplier);

        }
    }
}
