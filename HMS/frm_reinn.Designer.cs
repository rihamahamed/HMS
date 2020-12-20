namespace HMS
{
    partial class frm_reinn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_reinn));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hMSDataSet5 = new HMS.HMSDataSet5();
            this.innoviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.innoviceTableAdapter = new HMS.HMSDataSet5TableAdapters.InnoviceTableAdapter();
            this.innoviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalBillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthPeriedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthBillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.innoviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(575, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "NEW LANKA HOSPITAL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 60);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.innoviceIDDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn,
            this.patientNameDataGridViewTextBoxColumn,
            this.totalBillDataGridViewTextBoxColumn,
            this.monthPeriedDataGridViewTextBoxColumn,
            this.monthBillDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.innoviceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(638, 215);
            this.dataGridView1.TabIndex = 11;
            // 
            // hMSDataSet5
            // 
            this.hMSDataSet5.DataSetName = "HMSDataSet5";
            this.hMSDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // innoviceBindingSource
            // 
            this.innoviceBindingSource.DataMember = "Innovice";
            this.innoviceBindingSource.DataSource = this.hMSDataSet5;
            // 
            // innoviceTableAdapter
            // 
            this.innoviceTableAdapter.ClearBeforeFill = true;
            // 
            // innoviceIDDataGridViewTextBoxColumn
            // 
            this.innoviceIDDataGridViewTextBoxColumn.DataPropertyName = "InnoviceID";
            this.innoviceIDDataGridViewTextBoxColumn.HeaderText = "InnoviceID";
            this.innoviceIDDataGridViewTextBoxColumn.Name = "innoviceIDDataGridViewTextBoxColumn";
            this.innoviceIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            this.patientNameDataGridViewTextBoxColumn.DataPropertyName = "Patient_Name";
            this.patientNameDataGridViewTextBoxColumn.HeaderText = "Patient_Name";
            this.patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            this.patientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalBillDataGridViewTextBoxColumn
            // 
            this.totalBillDataGridViewTextBoxColumn.DataPropertyName = "Total_Bill";
            this.totalBillDataGridViewTextBoxColumn.HeaderText = "Total_Bill";
            this.totalBillDataGridViewTextBoxColumn.Name = "totalBillDataGridViewTextBoxColumn";
            this.totalBillDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monthPeriedDataGridViewTextBoxColumn
            // 
            this.monthPeriedDataGridViewTextBoxColumn.DataPropertyName = "Month_Peried";
            this.monthPeriedDataGridViewTextBoxColumn.HeaderText = "Month_Peried";
            this.monthPeriedDataGridViewTextBoxColumn.Name = "monthPeriedDataGridViewTextBoxColumn";
            this.monthPeriedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monthBillDataGridViewTextBoxColumn
            // 
            this.monthBillDataGridViewTextBoxColumn.DataPropertyName = "Month_Bill";
            this.monthBillDataGridViewTextBoxColumn.HeaderText = "Month_Bill";
            this.monthBillDataGridViewTextBoxColumn.Name = "monthBillDataGridViewTextBoxColumn";
            this.monthBillDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_reinn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 278);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_reinn";
            this.Text = "NEW LANKA HOSPITAL : INNOVICE REPORT";
            this.Load += new System.EventHandler(this.frm_reinn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.innoviceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HMSDataSet5 hMSDataSet5;
        private System.Windows.Forms.BindingSource innoviceBindingSource;
        private HMSDataSet5TableAdapters.InnoviceTableAdapter innoviceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn innoviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBillDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthPeriedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthBillDataGridViewTextBoxColumn;
    }
}