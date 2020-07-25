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
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            
            string username = username_txtbx.Text.ToString();
            string password = password_txtbx.Text.ToString();
            
            DBConnection con = new DBConnection();

            string query = "";
            
            if (username == "" || password == "")
            {
                MessageBox.Show("Missing info.");
            }
            else
            {
                if (personal_rb.Checked == true)
                {
                    query = $"SELECT * FROM personal WHERE admin = false AND user='{username}' AND pass='{password}'";
                    if (con.Control(query))
                    {
                        this.Hide();
                        personal_control objForm = new personal_control();
                        objForm.ShowDialog();
                        username_txtbx.Text = "";
                        password_txtbx.Text = "";
                        this.Close();
                    }
                }
                else
                {
                    query = $"SELECT * FROM personal WHERE admin = true AND user='{username}' AND pass='{password}'";
                    if (con.Control(query))
                    {
                        this.Hide();
                        admin_control objForm = new admin_control();
                        objForm.ShowDialog();
                        username_txtbx.Text = "";
                        password_txtbx.Text = "";
                        this.Close();
                    }
                }
            }
        }

        private void username_txtbx_Enter(object sender, EventArgs e)
        {
            username_txtbx.SelectAll();
        }

        private void username_txtbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_btn_Click(this, new EventArgs());
            }
        }

        private void password_txtbx_Enter(object sender, EventArgs e)
        {
            password_txtbx.SelectAll();
        }

        private void password_txtbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_btn_Click(this, new EventArgs());
            }
        }

        private void personal_rb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_btn_Click(this, new EventArgs());
            }
        }

        private void admin_rb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_btn_Click(this, new EventArgs());
            }
        }
    }
}
