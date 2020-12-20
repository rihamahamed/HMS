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
    public partial class frm_patient : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My Project\C#\HMS\HMS\HMS.mdf;Integrated Security=True");
        SqlCommand cmd;

                public frm_patient()
        {
            InitializeComponent();
        }

        private void btn_patclear_Click(object sender, EventArgs e)
        {
            txt_patid.Clear();
            txt_patname.Clear();
            txt_patnic.Clear();
            txt_patadd.Clear();
            txt_patconno.Clear();
            cmb_patbtype.ResetText();
            cmb_patgen.ResetText();
            cmb_patstatus.ResetText();
        }

        private void frm_patient_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_patsubmit_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand ("insert into Patient values('"+ txt_patid.Text + "', '" + txt_patname.Text + "' , '" + txt_patnic.Text + "' , '" + cmb_patgen.Text + "' , '" + txt_patconno.Text + "' , '" + txt_patadd.Text + "' , '" + cmb_patstatus.Text + "' , '" + cmb_patbtype.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show(txt_patid.Text + " Detailes Saved ");
            con.Close();
            this.Close();
        }
    }
}
