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
    public partial class frm_drugs : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My Project\C#\HMS\HMS\HMS.mdf;Integrated Security=True");
        SqlCommand cmd;
        public frm_drugs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Insert into Drugs Values('"+txt_druid.Text+"','"+txt_druname.Text+"','"+txt_supid.Text+"','"+txt_drudettail.Text+"')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show(txt_druid.Text + " Detailes Saved ");
            con.Close();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_drudettail.Clear();
            txt_druid.Clear();
            txt_druname.Clear();
            txt_supid.Clear();
        }
    }
}
