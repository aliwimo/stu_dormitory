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
    public partial class room_form : Form
    {
        public int last_page = 1;
        public int current_page = 1;
        public int limit = 10;
        public string query = "";
        public string page_query = "";

        public room_form()
        {
            InitializeComponent();
        }

        private void room_form_Load(object sender, EventArgs e)
        {
            DBConnection con = new DBConnection();
            con.Reader("SELECT room_id FROM room", "room_id", id_combx);
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
            query = $"SELECT " +
                    $"room.room_id AS 'Room NO', " +
                    $"GROUP_CONCAT(CONCAT(student.name, ' ',student.surname) SEPARATOR ', ') AS Students, " +
                    $"count(student.name) AS 'Number of Student', " +
                    $"room.capacity AS Capacity,(room.capacity - count(student.name)) AS 'Left Places'," +
                    $"IF((room.capacity - count(student.name) = 0) , (\"FULL\"),(\"Not FULL\")) AS 'Room State' FROM student " +
                    $"RIGHT OUTER JOIN room ON room.room_id = student.room_id GROUP BY room.room_id " +
                    $"ORDER BY room.room_id";

            this.paging(query);
            data_dgv.DataSource = con.SetDS(query).Tables[0];
            this.data_dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
            string id = id_combx.Text.ToString();

            if (id_combx.Text != "")
            {
                DBConnection con = new DBConnection();
                query = $"SELECT " +
                    $"room.room_id AS 'Room NO', " +
                    $"GROUP_CONCAT(CONCAT(student.name, ' ',student.surname) SEPARATOR ', ') AS Students, " +
                    $"count(student.name) AS 'Number of Student', " +
                    $"room.capacity AS Capacity,(room.capacity - count(student.name)) AS 'Left Places'," +
                    $"IF((room.capacity - count(student.name) = 0) , (\"FULL\"),(\"Not FULL\")) AS 'Room State' FROM student " +
                    $"RIGHT OUTER JOIN room ON room.room_id = student.room_id GROUP BY room.room_id HAVING room.room_id = {id} " +
                    $"ORDER BY room.room_id ";
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
            
            id_combx.SelectedIndex = -1;
            refresh();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            room_mod addNewRoom = new room_mod();
            addNewRoom.ShowDialog();
            refresh();
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
            }
            catch (Exception ex) { }
        }
    }
}
