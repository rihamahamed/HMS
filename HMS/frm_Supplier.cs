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


        public frm_Supplier()
        {
            InitializeComponent();
        }

        private void ViewData()
        {
            string quary = "Select * from Supplier";
            SqlDataAdapter sda = new SqlDataAdapter(quary,con);
            DataTable dt = new DataTable();

            con.Open();
            sda.Fill(dt);
            con.Close();
            dgv_supplier.DataSource = dt;
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
            
            string quary = "Insert into Supplier values('"+ txt_supid.Text +"','"+txt_supname.Text+"','"+txt_supnic.Text+"','"+cmb_supgen.Text+"','"+txt_supcono.Text+"','"+txt_supadd.Text+"')";
            SqlCommand cmd = new SqlCommand(quary,con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show(txt_supid.Text + " Detailes Saved ");
            con.Close();
            ViewData();
        }

        private void frm_Supplier_Load(object sender, EventArgs e)
        {
            ViewData();
        }

        private void dgv_supplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_supid.Text = dgv_supplier.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_supname.Text = dgv_supplier.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_supnic.Text = dgv_supplier.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmb_supgen.Text = dgv_supplier.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_supcono.Text = dgv_supplier.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_supadd.Text = dgv_supplier.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string quary = "Update Supplier SET Supplier_Name= '" + txt_supname.Text + "' ,Nic_or_Passport = '" + txt_supnic.Text + "' ,  Gender =  '" + cmb_supgen.Text + "', Contact_No =  '" + txt_supcono.Text + "', Address =  '" + txt_supadd.Text + "' WHERE SupplierID = '" + txt_supid.Text + "'";
            SqlCommand cmd = new SqlCommand(quary, con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show(txt_supid.Text + " Update Saved ");
            con.Close();
            ViewData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string message = "Do you want to Delete Record?";
            string title = "DELETE RECORD";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string quary = "DELETE FROM Supplier WHERE SupplierID = '" + txt_supid.Text + "'";
                SqlCommand cmd = new SqlCommand(quary, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(txt_supid.Text + " Data Delete ");
                con.Close();
                ViewData();
            }
            else
            {

            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string quary = "select * from Supplier WHERE SupplierID like '" + txt_search.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            DataTable dt = new DataTable();

            con.Open();
            sda.Fill(dt);
            con.Close();
            dgv_supplier.DataSource = dt;
        }
    }
}
