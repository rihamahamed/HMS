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
      

                public frm_patient()
        {
            InitializeComponent();
        }
        private void ViewData()
        {
            string quary = "select * from Patient";
            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            DataTable dt = new DataTable();

            con.Open();
            sda.Fill(dt);
            con.Close();
            dgv_Patient.DataSource = dt;
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
            ViewData();

        }

        private void btn_patsubmit_Click(object sender, EventArgs e)
        {
           
            string quary =  "insert into Patient values('"+ txt_patid.Text + "', '" + txt_patname.Text + "' , '" + txt_patnic.Text + "' , '" + cmb_patgen.Text + "' , '" + txt_patconno.Text + "' , '" + txt_patadd.Text + "' , '" + cmb_patstatus.Text + "' , '" + cmb_patbtype.Text + "')";
            SqlCommand cmd = new SqlCommand(quary,con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show(txt_patid.Text + " Detailes Saved ");
            con.Close();
            ViewData();

        }

        private void dgv_Patient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_patid.Text = dgv_Patient.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_patname.Text = dgv_Patient.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_patnic.Text = dgv_Patient.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmb_patgen.Text = dgv_Patient.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_patconno.Text = dgv_Patient.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_patadd.Text = dgv_Patient.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmb_patstatus.Text = dgv_Patient.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmb_patbtype.Text = dgv_Patient.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string quary = "Update Patient SET Patient_Name= '" + txt_patname.Text + "' , NIC_or_Passport = '" + txt_patnic.Text + "' ,  Gender =  '" + cmb_patgen.Text + "' , Contact_No =   '" + txt_patconno.Text + "' , Address =   '" + txt_patadd.Text + "' ,  Status = '" + cmb_patstatus.Text + "' , Blood_type = '" + cmb_patbtype.Text + "' WHERE PatientID = '"+txt_patid.Text+"'";
            SqlCommand cmd = new SqlCommand(quary,con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show(txt_patid.Text + " Update Saved ");
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
                string quary = "DELETE FROM Patient WHERE PatientID = '" + txt_patid.Text + "'";
                SqlCommand cmd = new SqlCommand(quary, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(txt_patid.Text + " Data Delete ");
                con.Close();
                ViewData();
            }
            else
            {

            }
            
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string quary = "select * from Patient WHERE PatientID like '"+txt_search.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            DataTable dt = new DataTable();

            con.Open();
            sda.Fill(dt);
            con.Close();
            dgv_Patient.DataSource = dt;

        }
    }
}
 