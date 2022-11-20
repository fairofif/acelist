using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acelist.entities
{
    public class Receptionist
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string pass;

        private List<string> employee_id = new List<string>();
        private List<string> username = new List<string>();
        private List<string> password = new List<string>();
        private List<string> name = new List<string>();
        private List<string> phone_number = new List<string>();

        public Receptionist()
        {
            initialize();
        }

        private void myCon()
        {
            this.server = "128.199.189.176";
            this.database = "acelistj_acelist";
            this.uid = "acelistj_rofif";
            this.pass = "Wakacipuy09";

            string connectionString;
            connectionString = "SERVER=" + this.server + ";" + "DATABASE=" +
            this.database + ";" + "UID=" + this.uid + ";" + "PASSWORD=" + this.pass + ";";

            this.connection = new MySqlConnection(connectionString);
        }

        public void initialize()
        {
            myCon();
            setArrEmployeeId();
            setArrName();
            setArrUsername();
            setArrPhoneNumber();
            setArrPassword();
        }

        private void setArrEmployeeId()
        {
            this.employee_id = new List<string>();
            string sqlQuery = "select employee_id from receptionist";
            MySqlCommand myCommand = new MySqlCommand(sqlQuery, this.connection);
            connection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    this.employee_id.Add(myReader.GetString(0));
                }
            }
            finally
            {
                myReader.Close();
                connection.Close();
            }
        }
        public List<string> getArrEmployeeId()
        {
            return this.employee_id;
        }

        private void setArrUsername()
        {
            this.username = new List<string>();
            string sqlQuery = "select username from receptionist";
            MySqlCommand myCommand = new MySqlCommand(sqlQuery, this.connection);
            connection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    this.username.Add(myReader.GetString(0));
                }
            }
            finally
            {
                myReader.Close();
                connection.Close();
            }
        }
        public List<string> getArrUsername()
        {
            return this.username;
        }
        private void setArrPassword()
        {
            this.password = new List<string>();
            string sqlQuery = "select password from receptionist";
            MySqlCommand myCommand = new MySqlCommand(sqlQuery, this.connection);
            connection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    this.password.Add(myReader.GetString(0));
                }
            }
            finally
            {
                myReader.Close();
                connection.Close();
            }
        }
        public List<string> getArrPassword()
        {
            return this.password;
        }

        private void setArrName()
        {
            this.name = new List<string>();
            string sqlQuery = "select name from receptionist";
            MySqlCommand myCommand = new MySqlCommand(sqlQuery, this.connection);
            connection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    this.name.Add(myReader.GetString(0));
                }
            }
            finally
            {
                myReader.Close();
                connection.Close();
            }
        }
        public List<string> getArrName()
        {
            return this.name;
        }

        private void setArrPhoneNumber()
        {
            this.phone_number = new List<string>();
            string sqlQuery = "select phone_number from receptionist";
            MySqlCommand myCommand = new MySqlCommand(sqlQuery, this.connection);
            connection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    this.phone_number.Add(myReader.GetString(0));
                }
            }
            finally
            {
                myReader.Close();
                connection.Close();
            }
        }
        public List<string> getArrPhoneNumber()
        {
            return this.phone_number;
        }

        public bool isIdExist(string id)
        {
            int i = 0;
            bool found = false;
            while (found == false && i < this.employee_id.Count)
            {
                if (employee_id[i] == id)
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }
            return found;
        }
        public bool isUsernameExist(string uname)
        {
            int i = 0;
            bool found = false;
            while (found == false && i < this.username.Count)
            {
                if (username[i] == uname)
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }
            return found;
        }

        public int idxUsername(string uname)
        {
            int i = 0;
            bool found = false;
            while (found == false && i < this.username.Count)
            {
                if (username[i] == uname)
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }
            return i;
        }

        public string getNameFromId(string id)
        {
            int i = 0;
            bool found = false;
            while (found == false && i < employee_id.Count)
            {
                if (id == employee_id[i])
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }
            return name[i];
        }

        public bool checkLogin(string uname, string pw)
        {
            int idx = idxUsername(uname); 
            if (username[idx] == uname && pw == password[idx])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void addAccount(string id, string uname, string pw, string nm, string ph)
        {
            string query = "insert into receptionist values ('" + id + "','" + uname + "','" + pw + "','" + nm + "','" + ph + "')";
            connection.Open();
            MySqlCommand myCommand = new MySqlCommand(query, this.connection);
            myCommand.ExecuteNonQuery();
            connection.Close();
            initialize();
        }

    }
}
