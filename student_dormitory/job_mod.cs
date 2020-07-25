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
    public partial class job_mod : Form
    {
        public job_mod()
        {
            InitializeComponent();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            DBConnection con = new DBConnection();

            string position = position_txtbx.Text.ToString();

            string query = $"INSERT INTO job(position) VALUES('{position}')";

            if (position_txtbx.Text != "")
            {
                try
                {
                    if (con.Counter($"SELECT * FROM job WHERE position='{position}'") <= 0)
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
                    position_txtbx.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Missing Data", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
