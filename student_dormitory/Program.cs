using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace VeriTaban
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login_form());
        }
    }
    class DBConnection
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnection()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "yurt_otomasyonu";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Cannot connect to server.  Contact administrator");
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert(string q)
        {
            string query = q;

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update(string q)
        {
            string query = q;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void Delete(string q, string id)
        {
            string query = q;

            if (this.OpenConnection() == true)
            {
                MySqlParameter[] par = new MySqlParameter[1];
                par[0] = new MySqlParameter("ID", MySqlDbType.Int32)
                {
                    Value = id.ToString()
                };
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = query;
                command.Parameters.AddRange(par);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();
            }
        }

        /*
        //Delete statement
        public void Delete(string q)
        {
            string query = q;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        */

        //Control statment
        public bool Control(string q)
        {
            string query = q;
            bool result = false;
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);


                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count <= 0)
                {
                    MessageBox.Show("Username Or Password Are Invalid");
                    result = false;
                }
                else
                {
                    //MessageBox.Show("Successful");
                    result = true;
                }
                table.Clear();
                //close connection
                this.CloseConnection();
            }
            return result;
        }


        //Reader statment
        public void Reader(string q, string column, ComboBox cb)
        {
            string query = q;
            cb.Items.Clear();

            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cb.Items.Add(reader.GetString($"{column}"));
                }

                //close connection
                this.CloseConnection();
            }
        }

        public void roomCheck(string q, string column, ComboBox cb)
        {
            string query = q;
            cb.Items.Clear();

            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetString($"{column}") == "FULL")
                    {
                        // don nothing
                    }
                    else
                    {
                        cb.Items.Add(reader.GetString($"{column}"));
                    }
                    
                }
                //close connection
                this.CloseConnection();
            }
        }
        public string Reader(string q, string column)
        {
            string query = q;
            string result = "";
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var ord = reader.GetOrdinal(column);
                    if (reader.IsDBNull(ord) == false)
                    {
                        result = reader.GetString($"{column}");
                    }
                    else
                    {
                        result = "";
                    }
                }

                //close connection
                this.CloseConnection();


                return result;
            }
            return result;
        }

        public void RoomReader(string q, string column, ComboBox cb)
        {
            string query = q;
            cb.Items.Clear();

            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetString($"{column}") == "Not FULL")
                    {
                        cb.Items.Add(reader.GetString($"{column}"));
                    }
                }

                //close connection
                this.CloseConnection();
            }
        }

        /*
        public void RoomCheck(ComboBox cb)
        {
            string query = "SELECT * FROM room";
            cb.Items.Clear();

            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string capacity = reader.GetString($"capacity");
                    string room_id = reader.GetString($"room_id");
                    int count = Counter($"SELECT * FROM student WHERE room_id ='{room_id}'");
                    if (capacity != count.ToString()) 
                    {
                        cb.Items.Add(reader.GetString($"capacity"));
                    }
                }
                //close connection
                this.CloseConnection();
            }
        }
        */




        public int Counter(string q)
        {
            string query = q;
            int result = 0;
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);


                DataTable table = new DataTable();
                adapter.Fill(table);

                result = table.Rows.Count;
                //close connection
                this.CloseConnection();
            }
            return result;
        }

        public DataSet SetDS(string q)
        {
            string query = q;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataSet DS = new DataSet();
                adapter.Fill(DS);
                //DGV.DataSource = DS.Tables[0];
                //close connection
                this.CloseConnection();
                return DS;
            }
            return null;
        }



    }
}
