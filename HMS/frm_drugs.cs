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
        public frm_drugs()
        {
            InitializeComponent();
        }
        private void ViewData()
        {
            string quary = "select * from Drug";
            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            DataTable dt = new DataTable();

            con.Open();
            sda.Fill(dt);
            con.Close();
            dgv_drugs.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string quary = "Insert into Drug Values('"+ txt_druid.Text +"','"+ txt_druname.Text +"','"+ txt_supid.Text +"','"+ txt_drudettail.Text +"')";
            SqlCommand cmd = new SqlCommand(quary,con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show(txt_druid.Text + " Detailes Saved ");
            con.Close();
            ViewData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_drudettail.Clear();
            txt_druid.Clear();
            txt_druname.Clear();
            txt_supid.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_drugs_Load(object sender, EventArgs e)
        {
            ViewData();
        }

        private void dgv_drugs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_druid.Text = dgv_drugs.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_druname.Text = dgv_drugs.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_supid.Text = dgv_drugs.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_drudettail.Text = dgv_drugs.Rows[e.RowIndex].Cells[3].Value.ToString();
          
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string quary = "Update Drug SET Drug_Name= '" + txt_druname.Text + "' , SupplierID = '" + txt_supid.Text + "' ,  Drug_Detailes =  '" + txt_drudettail.Text + "' WHERE DrugID = '" + txt_druid.Text + "'";
            SqlCommand cmd = new SqlCommand(quary, con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show(txt_druid.Text + " Update Saved ");
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
                string quary = "DELETE FROM Drug WHERE DrugID = '" + txt_druid.Text + "'";
                SqlCommand cmd = new SqlCommand(quary, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(txt_druid.Text + " Data Delete ");
                con.Close();
                ViewData();
            }
            else
            {

            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string quary = "select * from Drug WHERE DrugID like '" + txt_search.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            DataTable dt = new DataTable();

            con.Open();
            sda.Fill(dt);
            con.Close();
            dgv_drugs.DataSource = dt;
        }
    }
}
