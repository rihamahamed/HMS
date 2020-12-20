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
    public partial class frm_Supplier : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My Project\C#\HMS\HMS\HMS.mdf;Integrated Security=True");
        SqlCommand cmd;
        public frm_Supplier()
        {
            InitializeComponent();
        }

        private void btn_supclear_Click(object sender, EventArgs e)
        {
            txt_supadd.Clear();
            txt_supcono.Clear();
            txt_supid.Clear();
            txt_supname.Clear();
            txt_supnic.Clear();
            cmb_supgen.ResetText();
        }

        private void btn_supsubmit_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Insert into Supplier values('"+ txt_supid.Text +"','"+txt_supname.Text+"','"+txt_supnic.Text+"','"+cmb_supgen.Text+"','"+txt_supcono.Text+"','"+txt_supadd.Text+"')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show(txt_supadd.Text + " Detailes Saved ");
            con.Close();
            this.Close();
        }
    }
}
