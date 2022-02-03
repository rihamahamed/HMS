namespace HMS
{
    partial class frm_Supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Supplier));
            this.btn_supclear = new System.Windows.Forms.Button();
            this.btn_supsubmit = new System.Windows.Forms.Button();
            this.cmb_supgen = new System.Windows.Forms.ComboBox();
            this.txt_supcono = new System.Windows.Forms.TextBox();
            this.txt_supadd = new System.Windows.Forms.TextBox();
            this.txt_supnic = new System.Windows.Forms.TextBox();
            this.txt_supname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_supid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_supplier = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplier)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_supclear
            // 
            this.btn_supclear.Location = new System.Drawing.Point(280, 328);
            this.btn_supclear.Name = "btn_supclear";
            this.btn_supclear.Size = new System.Drawing.Size(75, 23);
            this.btn_supclear.TabIndex = 9;
            this.btn_supclear.Text = "Clear";
            this.btn_supclear.UseVisualStyleBackColor = true;
            this.btn_supclear.Click += new System.EventHandler(this.btn_supclear_Click);
            // 
            // btn_supsubmit
            // 
            this.btn_supsubmit.Location = new System.Drawing.Point(165, 328);
            this.btn_supsubmit.Name = "btn_supsubmit";
            this.btn_supsubmit.Size = new System.Drawing.Size(75, 23);
            this.btn_supsubmit.TabIndex = 8;
            this.btn_supsubmit.Text = "Submit";
            this.btn_supsubmit.UseVisualStyleBackColor = true;
            this.btn_supsubmit.Click += new System.EventHandler(this.btn_supsubmit_Click);
            // 
            // cmb_supgen
            // 
            this.cmb_supgen.FormattingEnabled = true;
            this.cmb_supgen.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_supgen.Location = new System.Drawing.Point(165, 162);
            this.cmb_supgen.Name = "cmb_supgen";
            this.cmb_supgen.Size = new System.Drawing.Size(190, 24);
            this.cmb_supgen.TabIndex = 4;
            // 
            // txt_supcono
            // 
            this.txt_supcono.Location = new System.Drawing.Point(165, 195);
            this.txt_supcono.Name = "txt_supcono";
            this.txt_supcono.Size = new System.Drawing.Size(190, 22);
            this.txt_supcono.TabIndex = 5;
            // 
            // txt_supadd
            // 
            this.txt_supadd.Location = new System.Drawing.Point(165, 223);
            this.txt_supadd.Multiline = true;
            this.txt_supadd.Name = "txt_supadd";
            this.txt_supadd.Size = new System.Drawing.Size(190, 70);
            this.txt_supadd.TabIndex = 7;
            // 
            // txt_supnic
            // 
            this.txt_supnic.Location = new System.Drawing.Point(165, 134);
            this.txt_supnic.Name = "txt_supnic";
            this.txt_supnic.Size = new System.Drawing.Size(190, 22);
            this.txt_supnic.TabIndex = 3;
            // 
            // txt_supname
            // 
            this.txt_supname.Location = new System.Drawing.Point(165, 106);
            this.txt_supname.Name = "txt_supname";
            this.txt_supname.Size = new System.Drawing.Size(190, 22);
            this.txt_supname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "NEW LANKA HOSPITAL";
            // 
            // txt_supid
            // 
            this.txt_supid.Location = new System.Drawing.Point(165, 78);
            this.txt_supid.Name = "txt_supid";
            this.txt_supid.Size = new System.Drawing.Size(190, 22);
            this.txt_supid.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 60);
            this.panel1.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 43;
            this.label8.Text = "Contect No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "NIC (or) Passport";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Full Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Supplier ID";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(574, 320);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(76, 31);
            this.btn_delete.TabIndex = 55;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(398, 320);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(76, 31);
            this.btn_update.TabIndex = 56;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(502, 80);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(220, 22);
            this.txt_search.TabIndex = 54;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Search by PatientID";
            // 
            // dgv_supplier
            // 
            this.dgv_supplier.AllowUserToAddRows = false;
            this.dgv_supplier.AllowUserToDeleteRows = false;
            this.dgv_supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_supplier.Location = new System.Drawing.Point(376, 108);
            this.dgv_supplier.Name = "dgv_supplier";
            this.dgv_supplier.ReadOnly = true;
            this.dgv_supplier.Size = new System.Drawing.Size(346, 185);
            this.dgv_supplier.TabIndex = 52;
            this.dgv_supplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_supplier_CellContentClick);
            // 
            // frm_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 367);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_supplier);
            this.Controls.Add(this.btn_supclear);
            this.Controls.Add(this.btn_supsubmit);
            this.Controls.Add(this.cmb_supgen);
            this.Controls.Add(this.txt_supcono);
            this.Controls.Add(this.txt_supadd);
            this.Controls.Add(this.txt_supnic);
            this.Controls.Add(this.txt_supname);
            this.Controls.Add(this.txt_supid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Supplier";
            this.Text = "NEW LANKA HOSPITAL : SUPPLIER";
            this.Load += new System.EventHandler(this.frm_Supplier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_supclear;
        private System.Windows.Forms.Button btn_supsubmit;
        private System.Windows.Forms.ComboBox cmb_supgen;
        private System.Windows.Forms.TextBox txt_supcono;
        private System.Windows.Forms.TextBox txt_supadd;
        private System.Windows.Forms.TextBox txt_supnic;
        private System.Windows.Forms.TextBox txt_supname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_supid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_supplier;
    }
}