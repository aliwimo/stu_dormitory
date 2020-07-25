namespace VeriTaban
{
    partial class dep_mod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dep_mod));
            this.dep_lbl = new System.Windows.Forms.Label();
            this.dep_txtbx = new System.Windows.Forms.TextBox();
            this.ok_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dep_lbl
            // 
            this.dep_lbl.AutoSize = true;
            this.dep_lbl.ForeColor = System.Drawing.Color.White;
            this.dep_lbl.Location = new System.Drawing.Point(12, 9);
            this.dep_lbl.Name = "dep_lbl";
            this.dep_lbl.Size = new System.Drawing.Size(125, 13);
            this.dep_lbl.TabIndex = 15;
            this.dep_lbl.Text = "DEPARTMENT  NAME :";
            // 
            // dep_txtbx
            // 
            this.dep_txtbx.Location = new System.Drawing.Point(15, 30);
            this.dep_txtbx.Name = "dep_txtbx";
            this.dep_txtbx.Size = new System.Drawing.Size(257, 20);
            this.dep_txtbx.TabIndex = 14;
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ok_btn.FlatAppearance.BorderSize = 0;
            this.ok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_btn.ForeColor = System.Drawing.Color.White;
            this.ok_btn.Location = new System.Drawing.Point(153, 64);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(119, 29);
            this.ok_btn.TabIndex = 32;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // dep_mod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(284, 105);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.dep_lbl);
            this.Controls.Add(this.dep_txtbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dep_mod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yurt++";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dep_lbl;
        private System.Windows.Forms.TextBox dep_txtbx;
        private System.Windows.Forms.Button ok_btn;
    }
}