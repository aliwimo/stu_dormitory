namespace VeriTaban
{
    partial class login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.username_lbl = new System.Windows.Forms.Label();
            this.username_txtbx = new System.Windows.Forms.TextBox();
            this.password_txtbx = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.personal_rb = new System.Windows.Forms.RadioButton();
            this.admin_rb = new System.Windows.Forms.RadioButton();
            this.login_btn = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.ForeColor = System.Drawing.Color.White;
            this.username_lbl.Location = new System.Drawing.Point(48, 174);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(74, 13);
            this.username_lbl.TabIndex = 0;
            this.username_lbl.Text = "USERNAME :";
            // 
            // username_txtbx
            // 
            this.username_txtbx.Location = new System.Drawing.Point(51, 195);
            this.username_txtbx.Name = "username_txtbx";
            this.username_txtbx.Size = new System.Drawing.Size(183, 20);
            this.username_txtbx.TabIndex = 1;
            this.username_txtbx.Enter += new System.EventHandler(this.username_txtbx_Enter);
            this.username_txtbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_txtbx_KeyDown);
            // 
            // password_txtbx
            // 
            this.password_txtbx.Location = new System.Drawing.Point(51, 254);
            this.password_txtbx.Name = "password_txtbx";
            this.password_txtbx.PasswordChar = '*';
            this.password_txtbx.Size = new System.Drawing.Size(183, 20);
            this.password_txtbx.TabIndex = 3;
            this.password_txtbx.Enter += new System.EventHandler(this.password_txtbx_Enter);
            this.password_txtbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_txtbx_KeyDown);
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.ForeColor = System.Drawing.Color.White;
            this.password_lbl.Location = new System.Drawing.Point(48, 233);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(76, 13);
            this.password_lbl.TabIndex = 2;
            this.password_lbl.Text = "PASSWORD :";
            // 
            // personal_rb
            // 
            this.personal_rb.AutoSize = true;
            this.personal_rb.Checked = true;
            this.personal_rb.ForeColor = System.Drawing.Color.White;
            this.personal_rb.Location = new System.Drawing.Point(51, 289);
            this.personal_rb.Name = "personal_rb";
            this.personal_rb.Size = new System.Drawing.Size(66, 17);
            this.personal_rb.TabIndex = 4;
            this.personal_rb.TabStop = true;
            this.personal_rb.Text = "Personal";
            this.personal_rb.UseVisualStyleBackColor = true;
            this.personal_rb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.personal_rb_KeyDown);
            // 
            // admin_rb
            // 
            this.admin_rb.AutoSize = true;
            this.admin_rb.ForeColor = System.Drawing.Color.White;
            this.admin_rb.Location = new System.Drawing.Point(123, 289);
            this.admin_rb.Name = "admin_rb";
            this.admin_rb.Size = new System.Drawing.Size(54, 17);
            this.admin_rb.TabIndex = 5;
            this.admin_rb.Text = "Admin";
            this.admin_rb.UseVisualStyleBackColor = true;
            this.admin_rb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.admin_rb_KeyDown);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(51, 322);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(92, 29);
            this.login_btn.TabIndex = 6;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // logo
            // 
            this.logo.Image = global::VeriTaban.Properties.Resources.logo1;
            this.logo.Location = new System.Drawing.Point(107, 72);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(64, 64);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(284, 417);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.admin_rb);
            this.Controls.Add(this.personal_rb);
            this.Controls.Add(this.password_txtbx);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.username_txtbx);
            this.Controls.Add(this.username_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yurt++";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.TextBox username_txtbx;
        private System.Windows.Forms.TextBox password_txtbx;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.RadioButton personal_rb;
        private System.Windows.Forms.RadioButton admin_rb;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.PictureBox logo;
    }
}

