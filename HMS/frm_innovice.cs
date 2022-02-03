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
        
        public frm_innovice()
        {
            InitializeComponent();
        }

        private void ViewData()
        {
            string quary = "Select * from Innovice";
            SqlDataAdapter sda = new SqlDataAdapter(quary,con);
            DataTable dt = new DataTable();

            con.Open();
            sda.Fill(dt);
            con.Close();
            dgv_Innovice.DataSource = dt;
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
            ViewData();
        }

        private void btn_insub_Click(object sender, EventArgs e)
        {
            
            string quary = "insert into Innovice values('"+ txt_inid.Text +"' , '" + txt_patid.Text + "', '" + txt_patname.Text + "' , '" + txt_intotalbil.Text + "' , '" + txt_inmon.Text + "' , '" + txt_inmonfee.Text + "')";
            SqlCommand cmd = new SqlCommand(quary,con);

            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show(txt_patid.Text + " Detailes Saved ");
            con.Close();
            ViewData();
        }

        private void rb_ininvers_CheckedChanged(object sender, EventArgs e)
        {
            double totalBill = double.Parse(txt_intotalbil.Text);
            double invoiceMonth = double.Parse(txt_inmon.Text);
            if (rb_ininvers.Checked)
            {
                

                txt_inmonfee.Text = (totalBill / invoiceMonth).ToString();
            }
            else
            {

            }
        }

        private void dgv_Innovice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_inid.Text = dgv_Innovice.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_patid.Text = dgv_Innovice.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_patname.Text = dgv_Innovice.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_intotalbil.Text = dgv_Innovice.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_inmon.Text = dgv_Innovice.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_inmonfee.Text = dgv_Innovice.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string quary = "Update Innovice SET PatientID= '" + txt_patid.Text + "' ,Patient_Name = '" + txt_patname.Text + "' ,  Total_Bill =  '" + txt_intotalbil.Text + "', Month_Peried =  '" + txt_inmon.Text + "', Month_Bill =  '" + txt_inmonfee.Text + "' WHERE InnoviceID = '" + txt_inid.Text + "'";
            SqlCommand cmd = new SqlCommand(quary, con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show(txt_inid.Text + " Update Saved ");
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
                string quary = "DELETE FROM Innovice WHERE InnoviceID = '" + txt_inid.Text + "'";
                SqlCommand cmd = new SqlCommand(quary, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(txt_inid.Text + " Data Delete ");
                con.Close();
                ViewData();
            }
            else
            {

            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string quary = "select * from Innovice WHERE InnoviceID like '" + txt_search.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            DataTable dt = new DataTable();

            con.Open();
            sda.Fill(dt);
            con.Close();
            dgv_Innovice.DataSource = dt;
        }
    }
}