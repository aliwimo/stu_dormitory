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
    public partial class dep_mod : Form
    {
        public dep_mod()
        {
            InitializeComponent();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            DBConnection con = new DBConnection();

            string department = dep_txtbx.Text.ToString();
            
            string query = $"INSERT INTO department(name) VALUES('{department}')";

            if (dep_txtbx.Text != "")
            {
                try
                {
                    if (con.Counter($"SELECT * FROM department WHERE name='{department}'") <= 0)
                    {
                        con.Insert(query);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Already Available !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
                finally
                {
                    dep_txtbx.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Missing Data", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
