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
    public partial class payment_details : Form
    {
        public string id;
        public payment_details(string i)
        {
            InitializeComponent();

            this.id = i;
        }

        private void payment_details_Load(object sender, EventArgs e)
        {
            this.refresh();
        }

        public void refresh()
        {
            DBConnection con = new DBConnection();
            string query = $"SELECT student.student_id As ID ,CONCAT(student.name,' ',student.surname) AS 'Full Name ', paid, date AS 'Date of Payment' FROM fees INNER JOIN student on student.student_id = fees.student_id WHERE fees.student_id = '{id}'";
            
            data_dgv.DataSource = con.SetDS(query).Tables[0];
            //to set last column to fill all width
            try
            {
                this.data_dgv.Columns[data_dgv.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                id = this.data_dgv.Rows[0].Cells[0].Value.ToString();
            }
            catch (Exception ex) { }

        }

        private void payment_btn_Click(object sender, EventArgs e)
        {
            payment_new myform = new payment_new(id);
            myform.ShowDialog();
            refresh();
            id = this.data_dgv.Rows[0].Cells[0].Value.ToString();
        }
    }
}
