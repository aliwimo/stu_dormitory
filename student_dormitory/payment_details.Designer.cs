namespace VeriTaban
{
    partial class payment_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payment_details));
            this.show_pnl = new System.Windows.Forms.Panel();
            this.data_dgv = new System.Windows.Forms.DataGridView();
            this.bottom_pnl = new System.Windows.Forms.Panel();
            this.payment_btn = new System.Windows.Forms.Button();
            this.show_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_dgv)).BeginInit();
            this.bottom_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // show_pnl
            // 
            this.show_pnl.Controls.Add(this.data_dgv);
            this.show_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.show_pnl.Location = new System.Drawing.Point(0, 0);
            this.show_pnl.Name = "show_pnl";
            this.show_pnl.Size = new System.Drawing.Size(474, 353);
            this.show_pnl.TabIndex = 0;
            // 
            // data_dgv
            // 
            this.data_dgv.AllowUserToAddRows = false;
            this.data_dgv.AllowUserToDeleteRows = false;
            this.data_dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.data_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_dgv.Location = new System.Drawing.Point(0, 0);
            this.data_dgv.MultiSelect = false;
            this.data_dgv.Name = "data_dgv";
            this.data_dgv.ReadOnly = true;
            this.data_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_dgv.Size = new System.Drawing.Size(474, 353);
            this.data_dgv.TabIndex = 1;
            // 
            // bottom_pnl
            // 
            this.bottom_pnl.Controls.Add(this.payment_btn);
            this.bottom_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_pnl.Location = new System.Drawing.Point(0, 298);
            this.bottom_pnl.Name = "bottom_pnl";
            this.bottom_pnl.Size = new System.Drawing.Size(474, 55);
            this.bottom_pnl.TabIndex = 1;
            // 
            // payment_btn
            // 
            this.payment_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.payment_btn.FlatAppearance.BorderSize = 0;
            this.payment_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payment_btn.ForeColor = System.Drawing.Color.White;
            this.payment_btn.Location = new System.Drawing.Point(343, 14);
            this.payment_btn.Name = "payment_btn";
            this.payment_btn.Size = new System.Drawing.Size(119, 29);
            this.payment_btn.TabIndex = 9;
            this.payment_btn.Text = "New Payment";
            this.payment_btn.UseVisualStyleBackColor = false;
            this.payment_btn.Click += new System.EventHandler(this.payment_btn_Click);
            // 
            // payment_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(474, 353);
            this.Controls.Add(this.bottom_pnl);
            this.Controls.Add(this.show_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "payment_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yurt++";
            this.Load += new System.EventHandler(this.payment_details_Load);
            this.show_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_dgv)).EndInit();
            this.bottom_pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel show_pnl;
        private System.Windows.Forms.Panel bottom_pnl;
        private System.Windows.Forms.Button payment_btn;
        private System.Windows.Forms.DataGridView data_dgv;
    }
}