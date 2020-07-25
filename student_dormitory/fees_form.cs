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
    public partial class fees_form : Form
    {
        public int last_page = 1;
        public int current_page = 1;
        public int limit = 10;
        public string query = "";
        public string page_query = "";
        public string id;

        public fees_form()
        {
            InitializeComponent();
        }

        private void fees_form_Load(object sender, EventArgs e)
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
            id = this.data_dgv.Rows[0].Cells[0].Value.ToString();
        }

        public void refresh()
        {
            DBConnection con = new DBConnection();
            query = $"SELECT student.student_id As ID ,CONCAT(student.name,' ',student.surname) AS 'Full Name ', SUM(fees.paid) AS PAID, (fees.amount - SUM(fees.paid)) AS 'LEFT' FROM fees INNER JOIN student on student.student_id = fees.student_id GROUP BY fees.student_id";
            
            this.paging(query);
            data_dgv.DataSource = con.SetDS(query).Tables[0];
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

            if (search != "")
            {
                DBConnection con = new DBConnection();
                query = $"SELECT student.student_id As ID ,CONCAT(student.name,' ',student.surname) AS 'Full Name' ,SUM(fees.paid) AS PAID, (fees.amount - SUM(fees.paid)) AS 'LEFT' FROM fees INNER JOIN student on student.student_id = fees.student_id GROUP BY fees.student_id HAVING student.student_id REGEXP '{search}'";
                //query = $"SELECT student_id AS ID, CONCAT(name, ' ', surname) AS Name, tc, reg_date AS 'Reg. Date' FROM student WHERE student_id REGEXP '{search}'";
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
            refresh();
            id = this.data_dgv.Rows[0].Cells[0].Value.ToString();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            payment_new myform = new payment_new(id);
            myform.ShowDialog();
            refresh();
            id = this.data_dgv.Rows[0].Cells[0].Value.ToString();
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
                this.id = this.data_dgv.Rows[0].Cells[0].Value.ToString();
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

        private void details_btn_Click(object sender, EventArgs e)
        {
            payment_details payment_details = new payment_details(id);
            payment_details.ShowDialog();
            refresh();
            this.id = this.data_dgv.Rows[0].Cells[0].Value.ToString();
        }
    }
}
