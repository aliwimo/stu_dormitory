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
    public partial class room_mod : Form
    {
        public room_mod()
        {
            InitializeComponent();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            DBConnection con = new DBConnection();

            string capacity = room_combx.Text.ToString();
            
            string query = $"INSERT INTO room(capacity) VALUES('{capacity}')";

            if (room_combx.SelectedIndex > -1)
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
                    room_combx.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Missing Data", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
