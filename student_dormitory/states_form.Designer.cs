namespace VeriTaban
{
    partial class states_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(states_form));
            this.txtbx = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.personal_rb = new System.Windows.Forms.RadioButton();
            this.student_rb = new System.Windows.Forms.RadioButton();
            this.out_btn = new System.Windows.Forms.Button();
            this.in_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbx
            // 
            this.txtbx.Location = new System.Drawing.Point(52, 67);
            this.txtbx.Name = "txtbx";
            this.txtbx.Size = new System.Drawing.Size(183, 20);
            this.txtbx.TabIndex = 1;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.ForeColor = System.Drawing.Color.White;
            this.password_lbl.Location = new System.Drawing.Point(49, 46);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(91, 13);
            this.password_lbl.TabIndex = 2;
            this.password_lbl.Text = "USERNAME - ID ";
            // 
            // personal_rb
            // 
            this.personal_rb.AutoSize = true;
            this.personal_rb.ForeColor = System.Drawing.Color.White;
            this.personal_rb.Location = new System.Drawing.Point(124, 102);
            this.personal_rb.Name = "personal_rb";
            this.personal_rb.Size = new System.Drawing.Size(66, 17);
            this.personal_rb.TabIndex = 3;
            this.personal_rb.Text = "Personal";
            this.personal_rb.UseVisualStyleBackColor = true;
            // 
            // student_rb
            // 
            this.student_rb.AutoSize = true;
            this.student_rb.Checked = true;
            this.student_rb.ForeColor = System.Drawing.Color.White;
            this.student_rb.Location = new System.Drawing.Point(52, 102);
            this.student_rb.Name = "student_rb";
            this.student_rb.Size = new System.Drawing.Size(62, 17);
            this.student_rb.TabIndex = 2;
            this.student_rb.TabStop = true;
            this.student_rb.Text = "Student";
            this.student_rb.UseVisualStyleBackColor = true;
            // 
            // out_btn
            // 
            this.out_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.out_btn.FlatAppearance.BorderSize = 0;
            this.out_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.out_btn.ForeColor = System.Drawing.Color.White;
            this.out_btn.Location = new System.Drawing.Point(52, 135);
            this.out_btn.Name = "out_btn";
            this.out_btn.Size = new System.Drawing.Size(87, 29);
            this.out_btn.TabIndex = 4;
            this.out_btn.Text = "OUT";
            this.out_btn.UseVisualStyleBackColor = false;
            this.out_btn.Click += new System.EventHandler(this.out_btn_Click);
            // 
            // in_btn
            // 
            this.in_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.in_btn.FlatAppearance.BorderSize = 0;
            this.in_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.in_btn.ForeColor = System.Drawing.Color.White;
            this.in_btn.Location = new System.Drawing.Point(148, 135);
            this.in_btn.Name = "in_btn";
            this.in_btn.Size = new System.Drawing.Size(87, 29);
            this.in_btn.TabIndex = 5;
            this.in_btn.Text = "IN";
            this.in_btn.UseVisualStyleBackColor = false;
            this.in_btn.Click += new System.EventHandler(this.in_btn_Click);
            // 
            // states_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(284, 198);
            this.Controls.Add(this.in_btn);
            this.Controls.Add(this.out_btn);
            this.Controls.Add(this.student_rb);
            this.Controls.Add(this.personal_rb);
            this.Controls.Add(this.txtbx);
            this.Controls.Add(this.password_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "states_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yurt++";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbx;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.RadioButton personal_rb;
        private System.Windows.Forms.RadioButton student_rb;
        private System.Windows.Forms.Button out_btn;
        private System.Windows.Forms.Button in_btn;
    }
}

