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
    public partial class payment_new : Form
    {
        public string id;
        public payment_new(string i)
        {
            InitializeComponent();

            this.id = i;

            id_txtbx.Text = id;
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            DBConnection con = new DBConnection();
            int paid = int.Parse(payment_txtbx.Text);
            string query = $"INSERT INTO fees(student_id, date, paid) VALUES('{id}', CURRENT_DATE(), '{paid}')";

            if (paid > 0)
            {
                try
                {
                    con.Insert(query);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
                finally
                {
                    payment_txtbx.Text  = "";
                }
            }
            else
            {
                MessageBox.Show("Missing Data", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
