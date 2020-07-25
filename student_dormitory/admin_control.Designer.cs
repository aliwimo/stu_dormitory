namespace VeriTaban
{
    partial class admin_control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_control));
            this.mainbar_pnl = new System.Windows.Forms.Panel();
            this.bottom_pnl = new System.Windows.Forms.Panel();
            this.archive_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.room_btn = new System.Windows.Forms.Button();
            this.fees_btn = new System.Windows.Forms.Button();
            this.sStates_btn = new System.Windows.Forms.Button();
            this.student_btn = new System.Windows.Forms.Button();
            this.student_lbl = new System.Windows.Forms.Label();
            this.pStates_btn = new System.Windows.Forms.Button();
            this.personal_lbl = new System.Windows.Forms.Label();
            this.personal_btn = new System.Windows.Forms.Button();
            this.body_pnl = new System.Windows.Forms.Panel();
            this.states_btn = new System.Windows.Forms.Button();
            this.mainbar_pnl.SuspendLayout();
            this.bottom_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainbar_pnl
            // 
            this.mainbar_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.mainbar_pnl.Controls.Add(this.bottom_pnl);
            this.mainbar_pnl.Controls.Add(this.room_btn);
            this.mainbar_pnl.Controls.Add(this.fees_btn);
            this.mainbar_pnl.Controls.Add(this.sStates_btn);
            this.mainbar_pnl.Controls.Add(this.student_btn);
            this.mainbar_pnl.Controls.Add(this.student_lbl);
            this.mainbar_pnl.Controls.Add(this.pStates_btn);
            this.mainbar_pnl.Controls.Add(this.personal_lbl);
            this.mainbar_pnl.Controls.Add(this.personal_btn);
            this.mainbar_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainbar_pnl.Location = new System.Drawing.Point(0, 0);
            this.mainbar_pnl.Name = "mainbar_pnl";
            this.mainbar_pnl.Size = new System.Drawing.Size(150, 493);
            this.mainbar_pnl.TabIndex = 0;
            this.mainbar_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.mainbar_pnl_Paint);
            // 
            // bottom_pnl
            // 
            this.bottom_pnl.Controls.Add(this.archive_btn);
            this.bottom_pnl.Controls.Add(this.logout_btn);
            this.bottom_pnl.Controls.Add(this.states_btn);
            this.bottom_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_pnl.Location = new System.Drawing.Point(0, 348);
            this.bottom_pnl.Name = "bottom_pnl";
            this.bottom_pnl.Size = new System.Drawing.Size(150, 145);
            this.bottom_pnl.TabIndex = 17;
            this.bottom_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.bottom_pnl_Paint);
            // 
            // archive_btn
            // 
            this.archive_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.archive_btn.FlatAppearance.BorderSize = 0;
            this.archive_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.archive_btn.ForeColor = System.Drawing.Color.White;
            this.archive_btn.Location = new System.Drawing.Point(17, 27);
            this.archive_btn.Name = "archive_btn";
            this.archive_btn.Size = new System.Drawing.Size(119, 29);
            this.archive_btn.TabIndex = 18;
            this.archive_btn.Text = "Archive";
            this.archive_btn.UseVisualStyleBackColor = false;
            this.archive_btn.Click += new System.EventHandler(this.archive_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Location = new System.Drawing.Point(17, 97);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(119, 29);
            this.logout_btn.TabIndex = 17;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // room_btn
            // 
            this.room_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.room_btn.FlatAppearance.BorderSize = 0;
            this.room_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.room_btn.ForeColor = System.Drawing.Color.White;
            this.room_btn.Location = new System.Drawing.Point(17, 204);
            this.room_btn.Name = "room_btn";
            this.room_btn.Size = new System.Drawing.Size(119, 29);
            this.room_btn.TabIndex = 15;
            this.room_btn.Text = "Room";
            this.room_btn.UseVisualStyleBackColor = false;
            this.room_btn.Click += new System.EventHandler(this.room_btn_Click);
            // 
            // fees_btn
            // 
            this.fees_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.fees_btn.FlatAppearance.BorderSize = 0;
            this.fees_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fees_btn.ForeColor = System.Drawing.Color.White;
            this.fees_btn.Location = new System.Drawing.Point(17, 169);
            this.fees_btn.Name = "fees_btn";
            this.fees_btn.Size = new System.Drawing.Size(119, 29);
            this.fees_btn.TabIndex = 14;
            this.fees_btn.Text = "Payments";
            this.fees_btn.UseVisualStyleBackColor = false;
            this.fees_btn.Click += new System.EventHandler(this.fees_btn_Click);
            // 
            // sStates_btn
            // 
            this.sStates_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.sStates_btn.FlatAppearance.BorderSize = 0;
            this.sStates_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sStates_btn.ForeColor = System.Drawing.Color.White;
            this.sStates_btn.Location = new System.Drawing.Point(17, 239);
            this.sStates_btn.Name = "sStates_btn";
            this.sStates_btn.Size = new System.Drawing.Size(119, 29);
            this.sStates_btn.TabIndex = 13;
            this.sStates_btn.Text = "Student States";
            this.sStates_btn.UseVisualStyleBackColor = false;
            this.sStates_btn.Click += new System.EventHandler(this.sStates_btn_Click);
            // 
            // student_btn
            // 
            this.student_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.student_btn.FlatAppearance.BorderSize = 0;
            this.student_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_btn.ForeColor = System.Drawing.Color.White;
            this.student_btn.Location = new System.Drawing.Point(17, 134);
            this.student_btn.Name = "student_btn";
            this.student_btn.Size = new System.Drawing.Size(119, 29);
            this.student_btn.TabIndex = 12;
            this.student_btn.Text = "Student";
            this.student_btn.UseVisualStyleBackColor = false;
            this.student_btn.Click += new System.EventHandler(this.student_btn_Click);
            // 
            // student_lbl
            // 
            this.student_lbl.AutoSize = true;
            this.student_lbl.ForeColor = System.Drawing.Color.White;
            this.student_lbl.Location = new System.Drawing.Point(14, 113);
            this.student_lbl.Name = "student_lbl";
            this.student_lbl.Size = new System.Drawing.Size(83, 13);
            this.student_lbl.TabIndex = 11;
            this.student_lbl.Text = "Student Section";
            // 
            // pStates_btn
            // 
            this.pStates_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pStates_btn.FlatAppearance.BorderSize = 0;
            this.pStates_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pStates_btn.ForeColor = System.Drawing.Color.White;
            this.pStates_btn.Location = new System.Drawing.Point(17, 74);
            this.pStates_btn.Name = "pStates_btn";
            this.pStates_btn.Size = new System.Drawing.Size(119, 29);
            this.pStates_btn.TabIndex = 9;
            this.pStates_btn.Text = "Personal States";
            this.pStates_btn.UseVisualStyleBackColor = false;
            this.pStates_btn.Click += new System.EventHandler(this.pStates_btn_Click);
            // 
            // personal_lbl
            // 
            this.personal_lbl.AutoSize = true;
            this.personal_lbl.ForeColor = System.Drawing.Color.White;
            this.personal_lbl.Location = new System.Drawing.Point(14, 18);
            this.personal_lbl.Name = "personal_lbl";
            this.personal_lbl.Size = new System.Drawing.Size(87, 13);
            this.personal_lbl.TabIndex = 8;
            this.personal_lbl.Text = "Personal Section";
            // 
            // personal_btn
            // 
            this.personal_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.personal_btn.FlatAppearance.BorderSize = 0;
            this.personal_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personal_btn.ForeColor = System.Drawing.Color.White;
            this.personal_btn.Location = new System.Drawing.Point(17, 39);
            this.personal_btn.Name = "personal_btn";
            this.personal_btn.Size = new System.Drawing.Size(119, 29);
            this.personal_btn.TabIndex = 7;
            this.personal_btn.Text = "Personal";
            this.personal_btn.UseVisualStyleBackColor = false;
            this.personal_btn.Click += new System.EventHandler(this.personal_btn_Click);
            // 
            // body_pnl
            // 
            this.body_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_pnl.Location = new System.Drawing.Point(150, 0);
            this.body_pnl.Name = "body_pnl";
            this.body_pnl.Size = new System.Drawing.Size(635, 493);
            this.body_pnl.TabIndex = 1;
            // 
            // states_btn
            // 
            this.states_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.states_btn.FlatAppearance.BorderSize = 0;
            this.states_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.states_btn.ForeColor = System.Drawing.Color.White;
            this.states_btn.Image = global::VeriTaban.Properties.Resources.fingerprint;
            this.states_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.states_btn.Location = new System.Drawing.Point(17, 62);
            this.states_btn.Name = "states_btn";
            this.states_btn.Size = new System.Drawing.Size(119, 29);
            this.states_btn.TabIndex = 16;
            this.states_btn.Text = "States";
            this.states_btn.UseVisualStyleBackColor = false;
            this.states_btn.Click += new System.EventHandler(this.states_btn_Click);
            // 
            // admin_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(785, 493);
            this.Controls.Add(this.body_pnl);
            this.Controls.Add(this.mainbar_pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "admin_control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yurt++";
            this.mainbar_pnl.ResumeLayout(false);
            this.mainbar_pnl.PerformLayout();
            this.bottom_pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainbar_pnl;
        private System.Windows.Forms.Panel body_pnl;
        private System.Windows.Forms.Label personal_lbl;
        private System.Windows.Forms.Button personal_btn;
        private System.Windows.Forms.Panel bottom_pnl;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button states_btn;
        private System.Windows.Forms.Button room_btn;
        private System.Windows.Forms.Button fees_btn;
        private System.Windows.Forms.Button sStates_btn;
        private System.Windows.Forms.Button student_btn;
        private System.Windows.Forms.Label student_lbl;
        private System.Windows.Forms.Button pStates_btn;
        private System.Windows.Forms.Button archive_btn;
    }
}