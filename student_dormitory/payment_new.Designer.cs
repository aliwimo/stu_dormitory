namespace VeriTaban
{
    partial class payment_new
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payment_new));
            this.position_lbl = new System.Windows.Forms.Label();
            this.ok_btn = new System.Windows.Forms.Button();
            this.id_txtbx = new System.Windows.Forms.TextBox();
            this.payment_txtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // position_lbl
            // 
            this.position_lbl.AutoSize = true;
            this.position_lbl.ForeColor = System.Drawing.Color.White;
            this.position_lbl.Location = new System.Drawing.Point(12, 9);
            this.position_lbl.Name = "position_lbl";
            this.position_lbl.Size = new System.Drawing.Size(24, 13);
            this.position_lbl.TabIndex = 15;
            this.position_lbl.Text = "ID :";
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
            // id_txtbx
            // 
            this.id_txtbx.Enabled = false;
            this.id_txtbx.Location = new System.Drawing.Point(15, 30);
            this.id_txtbx.Name = "id_txtbx";
            this.id_txtbx.Size = new System.Drawing.Size(119, 20);
            this.id_txtbx.TabIndex = 34;
            // 
            // payment_txtbx
            // 
            this.payment_txtbx.Location = new System.Drawing.Point(153, 30);
            this.payment_txtbx.Name = "payment_txtbx";
            this.payment_txtbx.Size = new System.Drawing.Size(119, 20);
            this.payment_txtbx.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(150, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "PAYMENT :";
            // 
            // payment_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(284, 105);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.payment_txtbx);
            this.Controls.Add(this.id_txtbx);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.position_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "payment_new";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yurt++";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label position_lbl;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.TextBox id_txtbx;
        private System.Windows.Forms.TextBox payment_txtbx;
        private System.Windows.Forms.Label label1;
    }
}