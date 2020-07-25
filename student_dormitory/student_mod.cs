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
    public partial class student_mod : Form
    {

        public string id;
        public student_mod(string i)
        {
            InitializeComponent();

            this.id = i;
        }

        private void student_mod_form_Load(object sender, EventArgs e)
        {
            DBConnection con = new DBConnection();

            string query = "SELECT room.room_id, IF((room.capacity - count(student.name) = 0) , (\"FULL\"),(\"Not FULL\")) AS 'Room State' FROM student RIGHT OUTER JOIN room ON room.room_id = student.room_id GROUP BY student.room_id";
            
            con.roomCheck(query, "room_id", room_combx);
            /*
            for (int i = 0; i < room_combx.Items.Count; i++)
            {
                if (con.Counter($"SELECT student_id FROM student WHERE room_id ='{room_combx.Items[i]}'")
                    .ToString() == con.Reader($"SELECT * FROM room WHERE room_id =" +
                    $"'{room_combx.Items[i]}'", "capacity"))
                {
                    room_combx.Items.RemoveAt(i);
                    if (i != room_combx.Items.Count)
                    {
                        i--;
                    }
                }
            }*/


            query = "SELECT * FROM department";
            con.Reader(query, "name", dep_combx);

            id_txtbx.Text = id;
            if (id != "-1")
            {
                
                id_txtbx.Text = id;
                string myQuery = $"SELECT * FROM student WHERE student_id = '{id}'";
                name_txtbx.Text = con.Reader(myQuery, "name");
                surname_txtbx.Text = con.Reader(myQuery, "surname");
                tc_txtbx.Text = con.Reader(myQuery, "tc");
                address_txtbx.Text = con.Reader(myQuery, "address");
                tel_txtbx.Text = con.Reader(myQuery, "tel");
                sclass_combx.SelectedItem = con.Reader(myQuery, "class");
                email_txtbx.Text = con.Reader(myQuery, "email");

                if (room_combx.Items.Contains(con.Reader(myQuery, "room_id")))
                {
                    //do nothing
                }
                else
                {
                    room_combx.Items.Add(con.Reader(myQuery, "room_id"));
                }
                room_combx.SelectedItem = con.Reader(myQuery, "room_id");
                string dep_id = con.Reader(myQuery, "dep_id");
                //myQuery = $"SELECT name FROM department WHERE dep_id = (SELECT dep_id FROM student WHERE student_id = {id})";
                myQuery = $"SELECT name FROM department WHERE dep_id = '{dep_id}'";
                dep_combx.SelectedItem = con.Reader(myQuery, "name");

                myQuery = $"SELECT DATE_FORMAT(reg_date, '%Y/%m/%d') AS reg_date FROM student WHERE student_id = {id}";
                string myDate = con.Reader(myQuery, "reg_date");
                DateTime Date = Convert.ToDateTime(myDate);
                this.reg_date_dtp.Value = Date;
            }
            else
            {
                id_txtbx.Text = "";
                this.reg_date_dtp.Value = DateTime.Now;
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
            string reg_date = reg_date_dtp.Text.ToString();
            string sclass = sclass_combx.Text.ToString();
            string room_id = room_combx.Text.ToString();
            string department = dep_combx.Text.ToString();
            string dep_id = con.Reader($"SELECT dep_id FROM department WHERE name = '{department}'", "dep_id");

            if (id != "-1")
            {
                string query = $"UPDATE student SET " +
                    $"name='{name}', " +
                    $"surname='{surname}', " +
                    $"tc='{tc}', " +
                    $"address='{address}', " +
                    $"email='{email}', " +
                    $"tel='{tel}', " +
                    $"reg_date='{reg_date}', " +
                    $"class='{sclass}', " +
                    $"room_id='{room_id}', " +
                    $"dep_id='{dep_id}' " +
                    $"WHERE student_id = '{id_txtbx.Text.ToString()}'";

                if (name_txtbx.Text != "" && surname_txtbx.Text != "" && tc_txtbx.Text != ""
                && reg_date_dtp.Text != "" && sclass_combx.SelectedIndex > -1 && room_combx.SelectedIndex > -1
                && dep_combx.SelectedIndex > -1)
                {
                    try
                    {
                        con.Update(query);
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
                        sclass_combx.SelectedIndex = -1;
                        room_combx.SelectedIndex = -1;
                        dep_combx.SelectedIndex = -1;
                    }
                }
            }
            else
            {
                string query =  $"INSERT INTO student(name, surname, tc, address, email, tel, reg_date, class, room_id, dep_id) " +
                                $"VALUES('{name}', '{surname}', '{tc}', '{address}', '{email}', '{tel}', '{reg_date}', '{sclass}', '{room_id}', '{dep_id}')";

                if (name_txtbx.Text != "" && surname_txtbx.Text != "" && tc_txtbx.Text != ""
                && reg_date_dtp.Text != "" && sclass_combx.SelectedIndex > -1 && room_combx.SelectedIndex > -1
                && dep_combx.SelectedIndex > -1)
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
                        id_txtbx.Text = "";
                        name_txtbx.Text = "";
                        surname_txtbx.Text = "";
                        tc_txtbx.Text = "";
                        address_txtbx.Text = "";
                        email_txtbx.Text = "";
                        tel_txtbx.Text = "";
                        sclass_combx.SelectedIndex = -1;
                        room_combx.SelectedIndex = -1;
                        dep_combx.SelectedIndex = -1;
                    }
                }
                else
                {
                    MessageBox.Show("Missing Data", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void add_dep_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            dep_mod addNewDep = new dep_mod();
            addNewDep.ShowDialog();
            this.Show();
            DBConnection con = new DBConnection();
            string myQuery = $"SELECT name FROM department";
            con.Reader(myQuery, "name", dep_combx);
            myQuery = $"SELECT name FROM department ORDER BY dep_id DESC LIMIT 1";
            dep_combx.SelectedItem = con.Reader(myQuery, "name");
        }

        private void add_room_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            room_mod addNewRoom = new room_mod();
            addNewRoom.ShowDialog();
            this.Show();
            DBConnection con = new DBConnection();
            string myQuery = $"SELECT room_id FROM room";
            con.Reader(myQuery, "room_id", room_combx);
            myQuery = $"SELECT room_id FROM room ORDER BY room_id DESC LIMIT 1";
            room_combx.SelectedItem = con.Reader(myQuery, "room_id");
        }
    }
}
