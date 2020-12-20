namespace HMS
{
    partial class frm_redru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_redru));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hMSDataSet3 = new HMS.HMSDataSet3();
            this.drugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugTableAdapter = new HMS.HMSDataSet3TableAdapters.DrugTableAdapter();
            this.drugIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugDetailesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 60);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEW LANKA HOSPITAL";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drugIDDataGridViewTextBoxColumn,
            this.drugNameDataGridViewTextBoxColumn,
            this.supplierIDDataGridViewTextBoxColumn,
            this.drugDetailesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.drugBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(444, 246);
            this.dataGridView1.TabIndex = 13;
            // 
            // hMSDataSet3
            // 
            this.hMSDataSet3.DataSetName = "HMSDataSet3";
            this.hMSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drugBindingSource
            // 
            this.drugBindingSource.DataMember = "Drug";
            this.drugBindingSource.DataSource = this.hMSDataSet3;
            // 
            // drugTableAdapter
            // 
            this.drugTableAdapter.ClearBeforeFill = true;
            // 
            // drugIDDataGridViewTextBoxColumn
            // 
            this.drugIDDataGridViewTextBoxColumn.DataPropertyName = "DrugID";
            this.drugIDDataGridViewTextBoxColumn.HeaderText = "DrugID";
            this.drugIDDataGridViewTextBoxColumn.Name = "drugIDDataGridViewTextBoxColumn";
            this.drugIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drugNameDataGridViewTextBoxColumn
            // 
            this.drugNameDataGridViewTextBoxColumn.DataPropertyName = "Drug_Name";
            this.drugNameDataGridViewTextBoxColumn.HeaderText = "Drug_Name";
            this.drugNameDataGridViewTextBoxColumn.Name = "drugNameDataGridViewTextBoxColumn";
            this.drugNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drugDetailesDataGridViewTextBoxColumn
            // 
            this.drugDetailesDataGridViewTextBoxColumn.DataPropertyName = "Drug_Detailes";
            this.drugDetailesDataGridViewTextBoxColumn.HeaderText = "Drug_Detailes";
            this.drugDetailesDataGridViewTextBoxColumn.Name = "drugDetailesDataGridViewTextBoxColumn";
            this.drugDetailesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_redru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 321);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_redru";
            this.Text = "NEW LANKA HOSPITAL : DRUGS REPORT";
            this.Load += new System.EventHandler(this.frm_redru_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HMSDataSet3 hMSDataSet3;
        private System.Windows.Forms.BindingSource drugBindingSource;
        private HMSDataSet3TableAdapters.DrugTableAdapter drugTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugDetailesDataGridViewTextBoxColumn;
    }
}