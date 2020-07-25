using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriTaban
{
    public partial class admin_control : Form
    {
        public admin_control()
        {
            InitializeComponent();
        }

        private void mainbar_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bottom_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void personal_btn_Click(object sender, EventArgs e)
        {
            body_pnl.Controls.Clear();
            personal_form objForm = new personal_form();
            objForm.TopLevel = false;
            body_pnl.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_form login_form = new login_form();
            login_form.ShowDialog();
        }

        private void student_btn_Click(object sender, EventArgs e)
        {
            body_pnl.Controls.Clear();
            student_form objForm = new student_form();
            objForm.TopLevel = false;
            body_pnl.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void states_btn_Click(object sender, EventArgs e)
        {
            states_form states_form = new states_form();
            states_form.ShowDialog();
        }

        private void pStates_btn_Click(object sender, EventArgs e)
        {
            body_pnl.Controls.Clear();
            personal_states objForm = new personal_states();
            objForm.TopLevel = false;
            body_pnl.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void sStates_btn_Click(object sender, EventArgs e)
        {
            body_pnl.Controls.Clear();
            student_states objForm = new student_states();
            objForm.TopLevel = false;
            body_pnl.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void fees_btn_Click(object sender, EventArgs e)
        {
            body_pnl.Controls.Clear();
            fees_form objForm = new fees_form();
            objForm.TopLevel = false;
            body_pnl.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void archive_btn_Click(object sender, EventArgs e)
        {
            body_pnl.Controls.Clear();
            archive_form objForm = new archive_form();
            objForm.TopLevel = false;
            body_pnl.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void room_btn_Click(object sender, EventArgs e)
        {
            body_pnl.Controls.Clear();
            room_form objForm = new room_form();
            objForm.TopLevel = false;
            body_pnl.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }
    }
}
