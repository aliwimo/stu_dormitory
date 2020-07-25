using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace VeriTaban
{
    public partial class personal_mod : Form
    {

        public string id;
        public personal_mod(string i)
        {
            InitializeComponent();

            this.id = i;
            
        }

        private void add_form_Load(object sender, EventArgs e)
        {
            DBConnection con = new DBConnection();
            string query = "SELECT * FROM job";

            con.Reader(query, "position", job_combx);

            id_txtbx.Text = id;
            if (id != "-1")
            {
                id_txtbx.Text = id;
                string myQuery = $"SELECT * FROM personal WHERE personal_id = '{id}'";
                name_txtbx.Text = con.Reader(myQuery, "name");
                surname_txtbx.Text = con.Reader(myQuery, "surname");
                tc_txtbx.Text = con.Reader(myQuery, "tc");
                address_txtbx.Text = con.Reader(myQuery, "address");
                tel_txtbx.Text = con.Reader(myQuery, "tel");
                user_txtbx.Text = con.Reader(myQuery, "user");
                pass_txtbx.Text = con.Reader(myQuery, "pass");
                email_txtbx.Text = con.Reader(myQuery, "email");
                string admin;

                if (con.Reader(myQuery, "admin") != "True")
                {
                    admin_chkbx.Checked = false;
                    admin = "0";
                }
                else
                {
                    admin_chkbx.Checked = true;
                    admin = "1";
                }


                string job_id = con.Reader(myQuery, "job_id");
                myQuery = $"SELECT position FROM job WHERE job_id = '{job_id}'";
                job_combx.SelectedItem = con.Reader(myQuery, "position");
                myQuery = $"SELECT amount FROM salary WHERE job_id = '{job_id}' AND personal_id = '{id}'";
                salary_txtbx.Text = con.Reader(myQuery, "amount");

                myQuery = $"SELECT DATE_FORMAT(start_date, '%Y/%m/%d') AS sdate, DATE_FORMAT(finish_date, '%Y-%m-%d') AS fdate FROM personal WHERE personal_id = {id}";
                string myDate = con.Reader(myQuery, "sdate");
                DateTime Date = Convert.ToDateTime(myDate);
                this.sdate_dtp.Value = Date;
                myDate = con.Reader(myQuery, "fdate");
                if (myDate == "")
                {
                    Date = DateTime.Now;
                    this.fdate_dtp.Value = Date;
                    this.fdate_dtp.Checked = false;
                }
                else
                {
                    Date = Convert.ToDateTime(myDate);
                    this.fdate_dtp.Value = Date;
                }





            }
            else
            {
                id_txtbx.Text = "";
                this.sdate_dtp.Value = DateTime.Now;
                this.fdate_dtp.Value = DateTime.Now;
                this.fdate_dtp.Checked = false;
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            DBConnection con = new DBConnection();

            string name = name_txtbx.Text.ToString();
            string surname = surname_txtbx.Text.ToString();
            string tc = tc_txtbx.Text.ToString();
            string address = address_txtbx.Text.ToString();
            string email = email_txtbx.Text.ToString();
            string tel = tel_txtbx.Text.ToString();
            string user = user_txtbx.Text.ToString();
            string pass = pass_txtbx.Text.ToString();
            string job = job_combx.Text.ToString();
            string job_id = con.Reader($"SELECT job_id FROM job WHERE position = '{job}'", "job_id");
            string salary = salary_txtbx.Text.ToString();
            string sdate = sdate_dtp.Text.ToString();
            string fdate;
            if (fdate_dtp.Checked == false)
            {
                fdate = "NULL";
            }
            else
            {
                fdate = "'"+fdate_dtp.Text.ToString()+"'";
            }

            string admin;

            if (admin_chkbx.Checked == true)
            {
                admin = "1";
            }
            else
            {
                admin = "0";
            }

            if (id != "-1") // so thats an edit proccess
            {
                string query = $"UPDATE personal SET " +
                    $"name='{name}', " +
                    $"surname='{surname}', " +
                    $"tc='{tc}', " +
                    $"address='{address}', " +
                    $"email='{email}', " +
                    $"tel='{tel}', " +
                    $"pass='{pass}', " +
                    $"start_date='{sdate}', " +
                    $"finish_date={fdate}, " +
                    $"job_id='{job_id}', " +
                    $"admin='{admin}' " +
                    $"WHERE personal_id = '{id_txtbx.Text.ToString()}'";

                if (name_txtbx.Text != "" && surname_txtbx.Text != "" && tc_txtbx.Text != ""
                && user_txtbx.Text != "" && pass_txtbx.Text != "" && job_combx.SelectedIndex > -1
                && sdate_dtp.Text != "" && salary_txtbx.Text != "")
                {
                    try
                    {
                        con.Update(query);
                        try
                        {
                            con.Delete("delete_salary", id);
                        }
                        catch (Exception ex) { };
                        //con.Update($"UPDATE salary SET personal_id = '{id}', job_id = '{job_id}', amount = '{salary}'");
                        con.Insert($"INSERT INTO salary(personal_id, job_id, amount) VALUES('{id}', '{job_id}', '{salary}')");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                    }
                    finally
                    {
                        id_txtbx.Text = "";
                        name_txtbx.Text = "";
                        surname_txtbx.Text = "";
                        tc_txtbx.Text = "";
                        address_txtbx.Text = "";
                        email_txtbx.Text = "";
                        tel_txtbx.Text = "";
                        user_txtbx.Text = "";
                        pass_txtbx.Text = "";
                        job_combx.SelectedIndex = -1;
                    }
                }
            }
            else
            {
                string query = $"INSERT INTO personal(name, surname, tc, address, email, tel, user, pass, start_date, finish_date, job_id, admin) " +
                            $"VALUES('{name}', '{surname}', '{tc}', '{address}', '{email}', '{tel}', '{user}', '{pass}', '{sdate}', {fdate}, '{job_id}', '{admin}')";

                if (name_txtbx.Text != "" && surname_txtbx.Text != "" && tc_txtbx.Text != ""
                && user_txtbx.Text != "" && pass_txtbx.Text != "" && job_combx.SelectedIndex > -1
                && sdate_dtp.Text != "" && salary_txtbx.Text != "")
                {
                    try
                    {
                        con.Insert(query);
                        string personal_id = con.Reader($"SELECT personal_id FROM personal WHERE user = '{user}'", "personal_id");
                        con.Insert($"INSERT INTO salary(personal_id, job_id, amount) VALUES('{personal_id}', '{job_id}', '{salary}')");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                    }
                    finally
                    {
                        id_txtbx.Text = "";
                        name_txtbx.Text = "";
                        surname_txtbx.Text = "";
                        tc_txtbx.Text = "";
                        address_txtbx.Text = "";
                        email_txtbx.Text = "";
                        tel_txtbx.Text = "";
                        user_txtbx.Text = "";
                        pass_txtbx.Text = "";
                        job_combx.SelectedIndex = -1;
                    }
                }
                else
                {
                    MessageBox.Show("Missing Data", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void add_job_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            job_mod addNewJob = new job_mod();
            addNewJob.ShowDialog();
            this.Show();
            DBConnection con = new DBConnection();
            string myQuery = $"SELECT position FROM job";
            con.Reader(myQuery, "position", job_combx);
            myQuery = $"SELECT position FROM job ORDER BY job_id DESC LIMIT 1";
            job_combx.SelectedItem = con.Reader(myQuery, "position");
            salary_txtbx.Text = "";
        }
    }
}
