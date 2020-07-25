namespace VeriTaban
{
    partial class room_mod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(room_mod));
            this.position_lbl = new System.Windows.Forms.Label();
            this.ok_btn = new System.Windows.Forms.Button();
            this.room_combx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // position_lbl
            // 
            this.position_lbl.AutoSize = true;
            this.position_lbl.ForeColor = System.Drawing.Color.White;
            this.position_lbl.Location = new System.Drawing.Point(12, 9);
            this.position_lbl.Name = "position_lbl";
            this.position_lbl.Size = new System.Drawing.Size(101, 13);
            this.position_lbl.TabIndex = 15;
            this.position_lbl.Text = "ROOM CAPACITY :";
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
            // room_combx
            // 
            this.room_combx.BackColor = System.Drawing.Color.White;
            this.room_combx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.room_combx.FormattingEnabled = true;
            this.room_combx.Items.AddRange(new object[] {
            "3",
            "4",
            "5"});
            this.room_combx.Location = new System.Drawing.Point(15, 30);
            this.room_combx.Name = "room_combx";
            this.room_combx.Size = new System.Drawing.Size(257, 21);
            this.room_combx.TabIndex = 33;
            // 
            // room_mod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(284, 105);
            this.Controls.Add(this.room_combx);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.position_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "room_mod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yurt++";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label position_lbl;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.ComboBox room_combx;
    }
}