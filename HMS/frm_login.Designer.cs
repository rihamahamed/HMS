namespace HMS
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_uname = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.cmb_utype = new System.Windows.Forms.ComboBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_pass = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEW LANKA HOSPITAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "User Type";
            // 
            // txt_uname
            // 
            this.txt_uname.Location = new System.Drawing.Point(120, 70);
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.Size = new System.Drawing.Size(198, 22);
            this.txt_uname.TabIndex = 1;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(120, 116);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(198, 22);
            this.txt_pass.TabIndex = 2;
            // 
            // cmb_utype
            // 
            this.cmb_utype.FormattingEnabled = true;
            this.cmb_utype.Items.AddRange(new object[] {
            "Doctor",
            "Nurse"});
            this.cmb_utype.Location = new System.Drawing.Point(120, 165);
            this.cmb_utype.Name = "cmb_utype";
            this.cmb_utype.Size = new System.Drawing.Size(198, 24);
            this.cmb_utype.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(120, 218);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 29);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_pass
            // 
            this.btn_pass.Location = new System.Drawing.Point(243, 218);
            this.btn_pass.Name = "btn_pass";
            this.btn_pass.Size = new System.Drawing.Size(75, 29);
            this.btn_pass.TabIndex = 5;
            this.btn_pass.Text = "Exit";
            this.btn_pass.UseVisualStyleBackColor = true;
            this.btn_pass.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 60);
            this.panel1.TabIndex = 8;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 271);
            this.Controls.Add(this.btn_pass);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.cmb_utype);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_uname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_login";
            this.Text = "NEW LANKA HOSPITAL : LOGIN";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_uname;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.ComboBox cmb_utype;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_pass;
        private System.Windows.Forms.Panel panel1;
    }
}