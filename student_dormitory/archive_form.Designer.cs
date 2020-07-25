namespace VeriTaban
{
    partial class archive_form
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
            this.side_pnl = new System.Windows.Forms.Panel();
            this.paging_pnl = new System.Windows.Forms.Panel();
            this.results_combx = new System.Windows.Forms.ComboBox();
            this.results_lbl = new System.Windows.Forms.Label();
            this.pages_lbl = new System.Windows.Forms.Label();
            this.prev_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.show_pnl = new System.Windows.Forms.Panel();
            this.data_dgv = new System.Windows.Forms.DataGridView();
            this.side_pnl.SuspendLayout();
            this.paging_pnl.SuspendLayout();
            this.show_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // side_pnl
            // 
            this.side_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.side_pnl.Controls.Add(this.paging_pnl);
            this.side_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_pnl.Location = new System.Drawing.Point(0, 0);
            this.side_pnl.Name = "side_pnl";
            this.side_pnl.Size = new System.Drawing.Size(150, 443);
            this.side_pnl.TabIndex = 0;
            // 
            // paging_pnl
            // 
            this.paging_pnl.Controls.Add(this.results_combx);
            this.paging_pnl.Controls.Add(this.results_lbl);
            this.paging_pnl.Controls.Add(this.pages_lbl);
            this.paging_pnl.Controls.Add(this.prev_btn);
            this.paging_pnl.Controls.Add(this.next_btn);
            this.paging_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paging_pnl.Location = new System.Drawing.Point(0, 330);
            this.paging_pnl.Name = "paging_pnl";
            this.paging_pnl.Size = new System.Drawing.Size(150, 113);
            this.paging_pnl.TabIndex = 17;
            // 
            // results_combx
            // 
            this.results_combx.FormattingEnabled = true;
            this.results_combx.Items.AddRange(new object[] {
            "2",
            "3",
            "5",
            "10",
            "25",
            "50",
            "100"});
            this.results_combx.Location = new System.Drawing.Point(17, 33);
            this.results_combx.Name = "results_combx";
            this.results_combx.Size = new System.Drawing.Size(119, 21);
            this.results_combx.TabIndex = 18;
            this.results_combx.Text = "10";
            this.results_combx.SelectedIndexChanged += new System.EventHandler(this.results_combx_SelectedIndexChanged);
            // 
            // results_lbl
            // 
            this.results_lbl.AutoSize = true;
            this.results_lbl.ForeColor = System.Drawing.Color.White;
            this.results_lbl.Location = new System.Drawing.Point(14, 11);
            this.results_lbl.Name = "results_lbl";
            this.results_lbl.Size = new System.Drawing.Size(87, 13);
            this.results_lbl.TabIndex = 18;
            this.results_lbl.Text = "Results in Page :";
            // 
            // pages_lbl
            // 
            this.pages_lbl.AutoSize = true;
            this.pages_lbl.ForeColor = System.Drawing.Color.White;
            this.pages_lbl.Location = new System.Drawing.Point(61, 74);
            this.pages_lbl.Name = "pages_lbl";
            this.pages_lbl.Size = new System.Drawing.Size(30, 13);
            this.pages_lbl.TabIndex = 20;
            this.pages_lbl.Text = "1 / 1";
            // 
            // prev_btn
            // 
            this.prev_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.prev_btn.FlatAppearance.BorderSize = 0;
            this.prev_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prev_btn.ForeColor = System.Drawing.Color.White;
            this.prev_btn.Location = new System.Drawing.Point(17, 66);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(29, 29);
            this.prev_btn.TabIndex = 19;
            this.prev_btn.Text = "<";
            this.prev_btn.UseVisualStyleBackColor = false;
            this.prev_btn.Click += new System.EventHandler(this.prev_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.next_btn.FlatAppearance.BorderSize = 0;
            this.next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_btn.ForeColor = System.Drawing.Color.White;
            this.next_btn.Location = new System.Drawing.Point(107, 66);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(29, 29);
            this.next_btn.TabIndex = 18;
            this.next_btn.Text = ">";
            this.next_btn.UseVisualStyleBackColor = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // show_pnl
            // 
            this.show_pnl.Controls.Add(this.data_dgv);
            this.show_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.show_pnl.Location = new System.Drawing.Point(150, 0);
            this.show_pnl.Name = "show_pnl";
            this.show_pnl.Size = new System.Drawing.Size(567, 443);
            this.show_pnl.TabIndex = 1;
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
            this.data_dgv.Size = new System.Drawing.Size(567, 443);
            this.data_dgv.TabIndex = 0;
            // 
            // archive_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(717, 443);
            this.Controls.Add(this.show_pnl);
            this.Controls.Add(this.side_pnl);
            this.Name = "archive_form";
            this.Text = "archive_form";
            this.Load += new System.EventHandler(this.archive_form_Load);
            this.side_pnl.ResumeLayout(false);
            this.paging_pnl.ResumeLayout(false);
            this.paging_pnl.PerformLayout();
            this.show_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel side_pnl;
        private System.Windows.Forms.Panel show_pnl;
        private System.Windows.Forms.Panel paging_pnl;
        private System.Windows.Forms.Label pages_lbl;
        private System.Windows.Forms.Button prev_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.DataGridView data_dgv;
        private System.Windows.Forms.ComboBox results_combx;
        private System.Windows.Forms.Label results_lbl;
    }
}