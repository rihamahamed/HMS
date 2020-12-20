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
    public partial class frm_login : Form
    {
        public SqlConnection con;
        public string str;
        public frm_login()
        {
            InitializeComponent();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My Project\C#\HMS\HMS\HMS.mdf;Integrated Security=True";
            con = new SqlConnection();
            con.ConnectionString = str;
            con.Open();
            MessageBox.Show("WELCOME NEW LANKA HOSPITAL");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String qry = "SELECT * FROM users where (UserID='" + txt_uname.Text + "' and Password='" + txt_pass.Text + "')";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string cmbitemvalue = cmb_utype.SelectedItem.ToString();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Usertype"].ToString() == cmbitemvalue)
                    {
                        if (cmb_utype.SelectedIndex == 0)
                        {
                            frm_mdr f1 = new frm_mdr();
                            f1.Show();
                            this.Hide();
                        }
                        else
                        {
                            frm_mnu f2 = new frm_mnu();
                            f2.Show();
                            this.Hide();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid entry please check your details.");
                txt_uname.Clear();
                txt_pass.Clear();
                txt_uname.Focus();
            }
        }
    }
}
