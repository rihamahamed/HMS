namespace HMS
{
    partial class frm_innovice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_innovice));
            this.btn_inclear = new System.Windows.Forms.Button();
            this.btn_insub = new System.Windows.Forms.Button();
            this.txt_patname = new System.Windows.Forms.TextBox();
            this.txt_intotalbil = new System.Windows.Forms.TextBox();
            this.txt_patid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_inid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_inspot = new System.Windows.Forms.RadioButton();
            this.rb_ininvers = new System.Windows.Forms.RadioButton();
            this.txt_inmon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_inmonfee = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dgv_Innovice = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Innovice)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_inclear
            // 
            this.btn_inclear.Location = new System.Drawing.Point(280, 356);
            this.btn_inclear.Name = "btn_inclear";
            this.btn_inclear.Size = new System.Drawing.Size(75, 31);
            this.btn_inclear.TabIndex = 11;
            this.btn_inclear.Text = "Clear";
            this.btn_inclear.UseVisualStyleBackColor = true;
            this.btn_inclear.Click += new System.EventHandler(this.btn_inclear_Click);
            // 
            // btn_insub
            // 
            this.btn_insub.Location = new System.Drawing.Point(165, 356);
            this.btn_insub.Name = "btn_insub";
            this.btn_insub.Size = new System.Drawing.Size(75, 31);
            this.btn_insub.TabIndex = 10;
            this.btn_insub.Text = "Submit";
            this.btn_insub.UseVisualStyleBackColor = true;
            this.btn_insub.Click += new System.EventHandler(this.btn_insub_Click);
            // 
            // txt_patname
            // 
            this.txt_patname.Location = new System.Drawing.Point(165, 173);
            this.txt_patname.Name = "txt_patname";
            this.txt_patname.Size = new System.Drawing.Size(190, 22);
            this.txt_patname.TabIndex = 3;
            // 
            // txt_intotalbil
            // 
            this.txt_intotalbil.Location = new System.Drawing.Point(165, 206);
            this.txt_intotalbil.Name = "txt_intotalbil";
            this.txt_intotalbil.Size = new System.Drawing.Size(190, 22);
            this.txt_intotalbil.TabIndex = 5;
            // 
            // txt_patid
            // 
            this.txt_patid.Location = new System.Drawing.Point(165, 145);
            this.txt_patid.Name = "txt_patid";
            this.txt_patid.Size = new System.Drawing.Size(190, 22);
            this.txt_patid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "NEW LANKA HOSPITAL";
            // 
            // txt_inid
            // 
            this.txt_inid.Location = new System.Drawing.Point(165, 117);
            this.txt_inid.Name = "txt_inid";
            this.txt_inid.Size = new System.Drawing.Size(190, 22);
            this.txt_inid.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 60);
            this.panel1.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 62;
            this.label8.Text = "Patient Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 61;
            this.label6.Text = "Total Bill";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "Patient ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Innovice ID";
            // 
            // rb_inspot
            // 
            this.rb_inspot.AutoSize = true;
            this.rb_inspot.Location = new System.Drawing.Point(165, 234);
            this.rb_inspot.Name = "rb_inspot";
            this.rb_inspot.Size = new System.Drawing.Size(110, 20);
            this.rb_inspot.TabIndex = 6;
            this.rb_inspot.TabStop = true;
            this.rb_inspot.Text = "Spot Payment";
            this.rb_inspot.UseVisualStyleBackColor = true;
            // 
            // rb_ininvers
            // 
            this.rb_ininvers.AutoSize = true;
            this.rb_ininvers.Location = new System.Drawing.Point(165, 260);
            this.rb_ininvers.Name = "rb_ininvers";
            this.rb_ininvers.Size = new System.Drawing.Size(91, 20);
            this.rb_ininvers.TabIndex = 7;
            this.rb_ininvers.TabStop = true;
            this.rb_ininvers.Text = "Inversment";
            this.rb_ininvers.UseVisualStyleBackColor = true;
            this.rb_ininvers.CheckedChanged += new System.EventHandler(this.rb_ininvers_CheckedChanged);
            // 
            // txt_inmon
            // 
            this.txt_inmon.Location = new System.Drawing.Point(271, 258);
            this.txt_inmon.Name = "txt_inmon";
            this.txt_inmon.Size = new System.Drawing.Size(84, 22);
            this.txt_inmon.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Month Fees";
            // 
            // txt_inmonfee
            // 
            this.txt_inmonfee.Location = new System.Drawing.Point(165, 286);
            this.txt_inmonfee.Name = "txt_inmonfee";
            this.txt_inmonfee.Size = new System.Drawing.Size(190, 22);
            this.txt_inmonfee.TabIndex = 9;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(591, 356);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(76, 31);
            this.btn_delete.TabIndex = 67;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(415, 356);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(76, 31);
            this.btn_update.TabIndex = 68;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(525, 75);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(220, 22);
            this.txt_search.TabIndex = 66;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // dgv_Innovice
            // 
            this.dgv_Innovice.AllowUserToAddRows = false;
            this.dgv_Innovice.AllowUserToDeleteRows = false;
            this.dgv_Innovice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Innovice.Location = new System.Drawing.Point(385, 106);
            this.dgv_Innovice.Name = "dgv_Innovice";
            this.dgv_Innovice.ReadOnly = true;
            this.dgv_Innovice.Size = new System.Drawing.Size(360, 244);
            this.dgv_Innovice.TabIndex = 65;
            this.dgv_Innovice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Innovice_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 64;
            this.label5.Text = "Search by PatientID";
            // 
            // frm_innovice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 407);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgv_Innovice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_inmon);
            this.Controls.Add(this.rb_ininvers);
            this.Controls.Add(this.rb_inspot);
            this.Controls.Add(this.btn_inclear);
            this.Controls.Add(this.btn_insub);
            this.Controls.Add(this.txt_patname);
            this.Controls.Add(this.txt_inmonfee);
            this.Controls.Add(this.txt_intotalbil);
            this.Controls.Add(this.txt_patid);
            this.Controls.Add(this.txt_inid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_innovice";
            this.Text = "NEW LANKA HOSPITAL : INNOVICE";
            this.Load += new System.EventHandler(this.frm_innovice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Innovice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_inclear;
        private System.Windows.Forms.Button btn_insub;
        private System.Windows.Forms.TextBox txt_patname;
        private System.Windows.Forms.TextBox txt_intotalbil;
        private System.Windows.Forms.TextBox txt_patid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_inid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_inspot;
        private System.Windows.Forms.RadioButton rb_ininvers;
        private System.Windows.Forms.TextBox txt_inmon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_inmonfee;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView dgv_Innovice;
        private System.Windows.Forms.Label label5;
    }
}