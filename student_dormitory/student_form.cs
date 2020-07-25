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
    public partial class student_form : Form
    {
        public int last_page = 1;
        public int current_page = 1;
        public int limit = 10;
        public string query = "";
        public string page_query = "";
        public string id;

        public student_form()
        {
            InitializeComponent();
        }

        private void student_form_Load(object sender, EventArgs e)
        {
            refresh();
            current_page = 1;
            if (current_page == last_page)
            {
                prev_btn.Enabled = true;
                next_btn.Enabled = false;
            }
            if (current_page == 1)
            {
                prev_btn.Enabled = false;
            }
            try
            {
                id = this.data_dgv.Rows[0].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                Start:
                DialogResult addNewStudent = MessageBox.Show("There is no Registered Students, Add a new student?", "Important Question", MessageBoxButtons.YesNo);
                if (addNewStudent == DialogResult.Yes)
                {
                    student_mod myform = new student_mod("-1");
                    myform.ShowDialog();
                    refresh();
                    try
                    {
                        id = this.data_dgv.Rows[0].Cells[0].Value.ToString();
                    }
                    catch (Exception ex2)
                    {
                        goto Start;
                    }
                }
                else
                {
                    DialogResult Exit = MessageBox.Show("Close Application", "Important Question", MessageBoxButtons.YesNo);
                    if (Exit == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        goto Start;
                    }
                }
            }
        }

        public void refresh()
        {
            DBConnection con = new DBConnection();
            query = $"SELECT student.student_id AS ID, CONCAT(student.name,' ',student.surname)AS 'Full Name', student.tc AS TC,student.reg_date AS Date, room.room_id AS 'Room NO' ,room.capacity AS Capacity, department.name AS Department, student.class AS Class FROM student INNER JOIN room ON student.room_id = room.room_id INNER JOIN department ON student.dep_id = department.dep_id";
            
            this.paging(query);
            data_dgv.DataSource = con.SetDS(page_query).Tables[0];
            
            //to set last column to fill all width
            try
            {
                this.data_dgv.Columns[data_dgv.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                id = this.data_dgv.Rows[0].Cells[0].Value.ToString();
            }
            catch (Exception ex) { }

        }

        public void paging(string query)
        {
            DBConnection con = new DBConnection();
            limit = Int32.Parse(results_combx.Text);
            if ((float)con.Counter(query) / limit == con.Counter(query) / limit)
            {
                this.last_page = (con.Counter(query) / limit);
            }
            else
            {

                this.last_page = (con.Counter(query) / limit) + 1;
            }
            this.page_query = query + $" LIMIT {(current_page - 1) * limit}, {limit}";
            pages_lbl.Text = $"{current_page} / {last_page}";
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (current_page < last_page)
            {
                current_page++;
                if (current_page == last_page)
                {
                    next_btn.Enabled = false;
                }
            }
            if (current_page > 1)
            {
                prev_btn.Enabled = true;
            }
            DBConnection con = new DBConnection();
            this.paging(query);
            data_dgv.DataSource = con.SetDS(page_query).Tables[0];
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            if (current_page > 1)
            {
                current_page--;
                if (current_page == 1)
                {
                    prev_btn.Enabled = false;
                }
            }
            if (current_page < last_page)
            {
                next_btn.Enabled = true;
            }
            DBConnection con = new DBConnection();
            this.paging(query);
            data_dgv.DataSource = con.SetDS(page_query).Tables[0];
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string search = search_txtbx.Text.ToString();
            string by = by_combx.Text.ToString();

            if (search != "" && by_combx.Text != "")
            {
                DBConnection con = new DBConnection();
                query = $"SELECT student.student_id AS ID, CONCAT(student.name,' ',student.surname)AS 'Full Name', student.tc AS TC,student.reg_date AS Date, room.room_id AS 'Room NO' ,room.capacity AS Capacity, department.name AS Department, student.class AS Class FROM student INNER JOIN room ON student.room_id = room.room_id INNER JOIN department ON student.dep_id = department.dep_id WHERE student.{by} REGEXP '{search}'";
                //query = $"SELECT student_id AS ID, CONCAT(name, ' ', surname) AS Name, tc, reg_date AS 'Reg. Date' FROM student WHERE {by} REGEXP '{search}'";
                this.last_page = (con.Counter(query) / limit) + 1;
                this.page_query = query + $" LIMIT {(current_page - 1) * limit}, {limit}";
                pages_lbl.Text = $"{current_page} / {last_page}";
                data_dgv.DataSource = con.SetDS(page_query).Tables[0];

                //to set last column to fill all width
                try
                {
                    this.data_dgv.Columns[data_dgv.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    id = this.data_dgv.Rows[0].Cells[0].Value.ToString();
                }
                catch (Exception ex) { }
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            search_txtbx.Text = "";
            by_combx.SelectedIndex = 0;
            refresh();
            id = this.data_dgv.Rows[0].Cells[0].Value.ToString();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            student_mod myform = new student_mod("-1");
            myform.ShowDialog();
            refresh();
            id = this.data_dgv.Rows[0].Cells[0].Value.ToString();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            student_mod myform = new student_mod(id);
            myform.ShowDialog();
            refresh();
            id = this.data_dgv.Rows[0].Cells[0].Value.ToString();
        }

        /*
        private void delete_btn_Click(object sender, EventArgs e)
        {
            DBConnection con = new DBConnection();
            string delQuery = $"DELETE FROM personal WHERE personal_id = '{id}'";
            try
            {
                DialogResult result = MessageBox.Show("Are you Sure LAN", "Important Question", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    con.Delete(delQuery);
                    refresh();
                    id = this.data_dgv.Rows[0].Cells[0].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }
            finally
            {
                search_txtbx.Text = "";
                by_combx.SelectedIndex = -1;
            }
        }
        */

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DBConnection con = new DBConnection();
            string delQuery = "delete_student";
            try
            {
                DialogResult result = MessageBox.Show("Are you Sure?", "Important Question", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    con.Delete(delQuery, id);
                    refresh();
                    try
                    {
                        id = this.data_dgv.Rows[0].Cells[0].Value.ToString();
                    }
                    catch (Exception ex)
                    {
                        Start:
                        DialogResult addNewStudent = MessageBox.Show("There is no Registered Students, Add a new student?", "Important Question", MessageBoxButtons.YesNo);
                        if (addNewStudent == DialogResult.Yes)
                        {
                            student_mod myform = new student_mod("-1");
                            myform.ShowDialog();
                            refresh();
                            try
                            {
                                id = this.data_dgv.Rows[0].Cells[0].Value.ToString();
                            }
                            catch (Exception ex2)
                            {
                                goto Start;
                            }
                        }
                        else
                        {
                            DialogResult Exit = MessageBox.Show("Close Application", "Important Question", MessageBoxButtons.YesNo);
                            if (Exit == DialogResult.Yes)
                            {
                                Application.Exit();
                            }
                            else
                            {
                                goto Start;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }
            finally
            {
                search_txtbx.Text = "";
                by_combx.SelectedIndex = -1;
            }
        }

        private void results_combx_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBConnection con = new DBConnection();
            current_page = 1;
            this.paging(query);
            if (last_page == 1)
            {
                this.next_btn.Enabled = false;
            }
            else
            {
                this.next_btn.Enabled = true;
            }
            prev_btn.Enabled = false;
            data_dgv.DataSource = con.SetDS(page_query).Tables[0];
            //to set last column to fill all width
            try
            {
                this.data_dgv.Columns[data_dgv.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                id = this.data_dgv.Rows[0].Cells[0].Value.ToString();
            }
            catch (Exception ex) { }
        }

        private void data_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = data_dgv.SelectedCells[0].RowIndex;
            this.id = this.data_dgv.Rows[index].Cells[0].Value.ToString();
        }

        private void data_dgv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.id = this.data_dgv.Rows[0].Cells[0].Value.ToString();
        }
    }
}
