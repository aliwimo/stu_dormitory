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
    public partial class states_form : Form
    {
        public states_form()
        {
            InitializeComponent();
        }

        
        private void in_btn_Click(object sender, EventArgs e)
        {
            DBConnection con = new DBConnection();
            int personal = con.Counter($"SELECT user FROM personal WHERE user='{txtbx.Text}'");
            int student = con.Counter($"SELECT student_id FROM student WHERE student_id='{txtbx.Text}'");

            if (txtbx.Text == "")
            {
                MessageBox.Show("Missing info.");
            }
            else
            {
                if (personal_rb.Checked == true)
                {
                    if (personal > 0)
                    {
                        try
                        {
                            string date = DateTime.Now.ToString("yyyy/MM/dd H:mm:ss");
                            string id = con.Reader($"SELECT personal_id FROM personal WHERE user = '{txtbx.Text}'", "personal_id");
                            string query = $"INSERT INTO states(personal, id, state, date)" +
                                            $"VALUES('1', '{id}', 'in', '{date}')";
                            con.Insert(query);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("INCORRECT ENTRY");
                    }
                }
                else
                {
                    if (student > 0)
                    {
                        try
                        {
                            string date = DateTime.Now.ToString("yyyy/MM/dd H:mm:ss");
                            string id = con.Reader($"SELECT student_id FROM student WHERE student_id = '{txtbx.Text}'", "student_id");
                            string query = $"INSERT INTO states(personal, id, state, date)" +
                                            $"VALUES('0', '{id}', 'in', '{date}')";
                            con.Insert(query);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("INCORRECT ENTRY");
                    }
                }
            }
        }
        

        private void out_btn_Click(object sender, EventArgs e)
        {
            DBConnection con = new DBConnection();
            int personal = con.Counter($"SELECT user FROM personal WHERE user='{txtbx.Text}'");
            int student = con.Counter($"SELECT student_id FROM student WHERE student_id='{txtbx.Text}'");

            if (txtbx.Text == "")
            {
                MessageBox.Show("Missing info.");
            }
            else
            {
                if (personal_rb.Checked == true)
                {
                    if (personal_rb.Checked == true)
                    {
                        if (personal > 0)
                        {
                            try
                            {
                                string date = DateTime.Now.ToString("yyyy/MM/dd H:mm:ss");
                                string id = con.Reader($"SELECT personal_id FROM personal WHERE user = '{txtbx.Text}'", "personal_id");
                                string query = $"INSERT INTO states(personal, id, state, date)" +
                                                $"VALUES('1', '{id}', 'out', '{date}')";
                                con.Insert(query);
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("INCORRECT ENTRY");
                        }
                    }
                }
                else if (student_rb.Checked == true)
                {
                    if (student > 0)
                    {
                        try
                        {
                            string date = DateTime.Now.ToString("yyyy/MM/dd H:mm:ss");
                            string id = con.Reader($"SELECT student_id FROM student WHERE student_id = '{txtbx.Text}'", "student_id");
                            string query = $"INSERT INTO states(personal, id, state, date)" +
                                            $"VALUES('0', '{id}', 'out', '{date}')";
                            con.Insert(query);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("INCORRECT ENTRY");
                    }
                }
            }
        }
    }
}
