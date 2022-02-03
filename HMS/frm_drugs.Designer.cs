namespace HMS
{
    partial class frm_drugs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_drugs));
            this.btn_drcl = new System.Windows.Forms.Button();
            this.btn_drsub = new System.Windows.Forms.Button();
            this.txt_supid = new System.Windows.Forms.TextBox();
            this.txt_drudettail = new System.Windows.Forms.TextBox();
            this.txt_druname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_druid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_drugs = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drugs)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_drcl
            // 
            this.btn_drcl.Location = new System.Drawing.Point(280, 288);
            this.btn_drcl.Name = "btn_drcl";
            this.btn_drcl.Size = new System.Drawing.Size(75, 31);
            this.btn_drcl.TabIndex = 7;
            this.btn_drcl.Text = "Clear";
            this.btn_drcl.UseVisualStyleBackColor = true;
            this.btn_drcl.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_drsub
            // 
            this.btn_drsub.Location = new System.Drawing.Point(165, 288);
            this.btn_drsub.Name = "btn_drsub";
            this.btn_drsub.Size = new System.Drawing.Size(75, 31);
            this.btn_drsub.TabIndex = 6;
            this.btn_drsub.Text = "Submit";
            this.btn_drsub.UseVisualStyleBackColor = true;
            this.btn_drsub.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_supid
            // 
            this.txt_supid.Location = new System.Drawing.Point(165, 134);
            this.txt_supid.Name = "txt_supid";
            this.txt_supid.Size = new System.Drawing.Size(190, 22);
            this.txt_supid.TabIndex = 3;
            // 
            // txt_drudettail
            // 
            this.txt_drudettail.Location = new System.Drawing.Point(165, 167);
            this.txt_drudettail.Multiline = true;
            this.txt_drudettail.Name = "txt_drudettail";
            this.txt_drudettail.Size = new System.Drawing.Size(190, 70);
            this.txt_drudettail.TabIndex = 5;
            // 
            // txt_druname
            // 
            this.txt_druname.Location = new System.Drawing.Point(165, 106);
            this.txt_druname.Name = "txt_druname";
            this.txt_druname.Size = new System.Drawing.Size(190, 22);
            this.txt_druname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "NEW LANKA HOSPITAL";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_druid
            // 
            this.txt_druid.Location = new System.Drawing.Point(165, 78);
            this.txt_druid.Name = "txt_druid";
            this.txt_druid.Size = new System.Drawing.Size(190, 22);
            this.txt_druid.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 60);
            this.panel1.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 43;
            this.label8.Text = "Supplier ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Drug Detailes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Drug Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Drugs ID";
            // 
            // dgv_drugs
            // 
            this.dgv_drugs.AllowUserToAddRows = false;
            this.dgv_drugs.AllowUserToDeleteRows = false;
            this.dgv_drugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_drugs.Location = new System.Drawing.Point(380, 115);
            this.dgv_drugs.Name = "dgv_drugs";
            this.dgv_drugs.ReadOnly = true;
            this.dgv_drugs.Size = new System.Drawing.Size(346, 159);
            this.dgv_drugs.TabIndex = 47;
            this.dgv_drugs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_drugs_CellContentClick);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(577, 288);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(76, 31);
            this.btn_delete.TabIndex = 50;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(401, 288);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(76, 31);
            this.btn_update.TabIndex = 51;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(506, 87);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(220, 22);
            this.txt_search.TabIndex = 49;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "Search by PatientID";
            // 
            // frm_drugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 328);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_drugs);
            this.Controls.Add(this.btn_drcl);
            this.Controls.Add(this.btn_drsub);
            this.Controls.Add(this.txt_supid);
            this.Controls.Add(this.txt_drudettail);
            this.Controls.Add(this.txt_druname);
            this.Controls.Add(this.txt_druid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_drugs";
            this.Text = "NEW LANKA HOSPITAL : DRUGS";
            this.Load += new System.EventHandler(this.frm_drugs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drugs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_drcl;
        private System.Windows.Forms.Button btn_drsub;
        private System.Windows.Forms.TextBox txt_supid;
        private System.Windows.Forms.TextBox txt_drudettail;
        private System.Windows.Forms.TextBox txt_druname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_druid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_drugs;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label5;
    }
}