namespace HMS
{
    partial class frm_patient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_patient));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_patid = new System.Windows.Forms.TextBox();
            this.txt_patname = new System.Windows.Forms.TextBox();
            this.txt_patnic = new System.Windows.Forms.TextBox();
            this.cmb_patstatus = new System.Windows.Forms.ComboBox();
            this.txt_patconno = new System.Windows.Forms.TextBox();
            this.txt_patadd = new System.Windows.Forms.TextBox();
            this.cmb_patbtype = new System.Windows.Forms.ComboBox();
            this.cmb_patgen = new System.Windows.Forms.ComboBox();
            this.btn_patsubmit = new System.Windows.Forms.Button();
            this.btn_patclear = new System.Windows.Forms.Button();
            this.dgv_Patient = new System.Windows.Forms.DataGridView();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDataSet6 = new HMS.HMSDataSet6();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.patientTableAdapter = new HMS.HMSDataSet6TableAdapters.PatientTableAdapter();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 60);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "NEW LANKA HOSPITAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Full Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "NIC (or) Passport";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Contect No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Blood Type";
            // 
            // txt_patid
            // 
            this.txt_patid.Location = new System.Drawing.Point(166, 78);
            this.txt_patid.Name = "txt_patid";
            this.txt_patid.Size = new System.Drawing.Size(190, 22);
            this.txt_patid.TabIndex = 1;
            // 
            // txt_patname
            // 
            this.txt_patname.Location = new System.Drawing.Point(166, 106);
            this.txt_patname.Name = "txt_patname";
            this.txt_patname.Size = new System.Drawing.Size(190, 22);
            this.txt_patname.TabIndex = 2;
            // 
            // txt_patnic
            // 
            this.txt_patnic.Location = new System.Drawing.Point(166, 134);
            this.txt_patnic.Name = "txt_patnic";
            this.txt_patnic.Size = new System.Drawing.Size(190, 22);
            this.txt_patnic.TabIndex = 3;
            // 
            // cmb_patstatus
            // 
            this.cmb_patstatus.FormattingEnabled = true;
            this.cmb_patstatus.Items.AddRange(new object[] {
            "Maried",
            "Unmaried"});
            this.cmb_patstatus.Location = new System.Drawing.Point(166, 324);
            this.cmb_patstatus.Name = "cmb_patstatus";
            this.cmb_patstatus.Size = new System.Drawing.Size(190, 24);
            this.cmb_patstatus.TabIndex = 8;
            // 
            // txt_patconno
            // 
            this.txt_patconno.Location = new System.Drawing.Point(166, 220);
            this.txt_patconno.Name = "txt_patconno";
            this.txt_patconno.Size = new System.Drawing.Size(190, 22);
            this.txt_patconno.TabIndex = 6;
            // 
            // txt_patadd
            // 
            this.txt_patadd.Location = new System.Drawing.Point(166, 248);
            this.txt_patadd.Multiline = true;
            this.txt_patadd.Name = "txt_patadd";
            this.txt_patadd.Size = new System.Drawing.Size(190, 70);
            this.txt_patadd.TabIndex = 7;
            // 
            // cmb_patbtype
            // 
            this.cmb_patbtype.FormattingEnabled = true;
            this.cmb_patbtype.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cmb_patbtype.Location = new System.Drawing.Point(166, 354);
            this.cmb_patbtype.Name = "cmb_patbtype";
            this.cmb_patbtype.Size = new System.Drawing.Size(190, 24);
            this.cmb_patbtype.TabIndex = 9;
            // 
            // cmb_patgen
            // 
            this.cmb_patgen.FormattingEnabled = true;
            this.cmb_patgen.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_patgen.Location = new System.Drawing.Point(166, 162);
            this.cmb_patgen.Name = "cmb_patgen";
            this.cmb_patgen.Size = new System.Drawing.Size(190, 24);
            this.cmb_patgen.TabIndex = 4;
            // 
            // btn_patsubmit
            // 
            this.btn_patsubmit.Location = new System.Drawing.Point(166, 390);
            this.btn_patsubmit.Name = "btn_patsubmit";
            this.btn_patsubmit.Size = new System.Drawing.Size(75, 31);
            this.btn_patsubmit.TabIndex = 10;
            this.btn_patsubmit.Text = "Submit";
            this.btn_patsubmit.UseVisualStyleBackColor = true;
            this.btn_patsubmit.Click += new System.EventHandler(this.btn_patsubmit_Click);
            // 
            // btn_patclear
            // 
            this.btn_patclear.Location = new System.Drawing.Point(281, 390);
            this.btn_patclear.Name = "btn_patclear";
            this.btn_patclear.Size = new System.Drawing.Size(75, 31);
            this.btn_patclear.TabIndex = 11;
            this.btn_patclear.Text = "Clear";
            this.btn_patclear.UseVisualStyleBackColor = true;
            this.btn_patclear.Click += new System.EventHandler(this.btn_patclear_Click);
            // 
            // dgv_Patient
            // 
            this.dgv_Patient.AllowUserToAddRows = false;
            this.dgv_Patient.AllowUserToDeleteRows = false;
            this.dgv_Patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Patient.Location = new System.Drawing.Point(362, 112);
            this.dgv_Patient.Name = "dgv_Patient";
            this.dgv_Patient.ReadOnly = true;
            this.dgv_Patient.Size = new System.Drawing.Size(360, 266);
            this.dgv_Patient.TabIndex = 12;
            this.dgv_Patient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Patient_CellContentClick);
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.hMSDataSet6;
            // 
            // hMSDataSet6
            // 
            this.hMSDataSet6.DataSetName = "HMSDataSet6";
            this.hMSDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(502, 81);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(220, 22);
            this.txt_search.TabIndex = 13;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(392, 390);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(76, 31);
            this.btn_update.TabIndex = 15;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(568, 390);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(76, 31);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Search by PatientID";
            // 
            // frm_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 439);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgv_Patient);
            this.Controls.Add(this.btn_patclear);
            this.Controls.Add(this.btn_patsubmit);
            this.Controls.Add(this.cmb_patbtype);
            this.Controls.Add(this.cmb_patgen);
            this.Controls.Add(this.cmb_patstatus);
            this.Controls.Add(this.txt_patconno);
            this.Controls.Add(this.txt_patadd);
            this.Controls.Add(this.txt_patnic);
            this.Controls.Add(this.txt_patname);
            this.Controls.Add(this.txt_patid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_patient";
            this.Text = "NEW LANKA HOSPITAL : PATIENT";
            this.Load += new System.EventHandler(this.frm_patient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_patid;
        private System.Windows.Forms.TextBox txt_patname;
        private System.Windows.Forms.TextBox txt_patnic;
        private System.Windows.Forms.ComboBox cmb_patstatus;
        private System.Windows.Forms.TextBox txt_patconno;
        private System.Windows.Forms.TextBox txt_patadd;
        private System.Windows.Forms.ComboBox cmb_patbtype;
        private System.Windows.Forms.ComboBox cmb_patgen;
        private System.Windows.Forms.Button btn_patsubmit;
        private System.Windows.Forms.Button btn_patclear;
        private System.Windows.Forms.DataGridView dgv_Patient;
        private System.Windows.Forms.TextBox txt_search;
        private HMSDataSet6 hMSDataSet6;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private HMSDataSet6TableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label5;
    }
}