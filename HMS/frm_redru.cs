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
    public partial class frm_redru : Form
    {
        public frm_redru()
        {
            InitializeComponent();
        }

        private void frm_redru_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet3.Drug' table. You can move, or remove it, as needed.
            this.drugTableAdapter.Fill(this.hMSDataSet3.Drug);

        }
    }
}
