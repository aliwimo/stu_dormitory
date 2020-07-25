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
    public partial class personal_states : Form
    {
        public int last_page = 1;
        public int current_page = 1;
        public int limit = 10;
        public string query = "";
        public string page_query = "";
        public string date_format = "\"%d/%l/%Y %H:%i:%s\"";

        public personal_states()
        {
            InitializeComponent();
        }

        private void personal_states_Load(object sender, EventArgs e)
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
        }

        public void refresh()
        {
            DBConnection con = new DBConnection();
            query = $"SELECT states.id AS ID, CONCAT(personal.name, ' ', personal.surname) AS 'Full Name', UPPER(states.state) AS 'IN / OUT', DATE_FORMAT(date, {date_format}) AS 'Time' FROM states, personal WHERE states.personal = '1' AND states.id = personal.personal_id ORDER BY date DESC";
            this.paging(query);
            data_dgv.DataSource = con.SetDS(page_query).Tables[0];
            //to set last column to fill all width
            try
            {
                this.data_dgv.Columns[data_dgv.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
                query = $"SELECT states.id AS ID, CONCAT(personal.name, ' ', personal.surname) AS 'Full Name', UPPER(states.state) AS 'IN / OUT', DATE_FORMAT(date, {date_format}) AS 'Time' FROM states, personal WHERE states.personal = '1' AND states.id = personal.personal_id AND CONCAT(personal.name, ' ', personal.surname) REGEXP '{search}' ORDER BY date DESC ";
                this.last_page = (con.Counter(query) / limit) + 1;
                this.page_query = query + $" LIMIT {(current_page - 1) * limit}, {limit}";
                pages_lbl.Text = $"{current_page} / {last_page}";
                data_dgv.DataSource = con.SetDS(page_query).Tables[0];

                //to set last column to fill all width
                try
                {
                    this.data_dgv.Columns[data_dgv.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                catch (Exception ex) { }
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            search_txtbx.Text = "";
            by_combx.SelectedIndex = 0;
            refresh();
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
            }
            catch (Exception ex) { }
        }
    }
}
