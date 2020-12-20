using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMS
{
    public partial class frm_innovice : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My Project\C#\HMS\HMS\HMS.mdf;Integrated Security=True");
        SqlCommand cmd;

        public frm_innovice()
        {
            InitializeComponent();
        }

        private void btn_inclear_Click(object sender, EventArgs e)
        {
            txt_inid.Clear();
            txt_inmon.Clear();
            txt_inmonfee.Clear();
            txt_intotalbil.Clear();
            txt_patid.Clear();
            txt_patname.Clear();
        }

        private void frm_innovice_Load(object sender, EventArgs e)
        {

        }

        private void btn_insub_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into Innovice values('"+ txt_inid.Text +"' , '" + txt_patid.Text + "', '" + txt_patname.Text + "' , '" + txt_intotalbil.Text + "' , '" + txt_inmon.Text + "' , '" + txt_inmonfee.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show(txt_patid.Text + " Detailes Saved ");
            con.Close();
            this.Close();
        }
    }
}