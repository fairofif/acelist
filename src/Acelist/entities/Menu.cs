using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acelist.entities
{
    public class Menu
    {
        private List<int> item_id = new List<int>();
        private List<string> item_name = new List<string>();
        private List<int> item_price = new List<int>();

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Menu()
        {
            myCon();
            setArrItemId();
            setArrItemName();
            setArrItemPrice();
        }

        private void myCon()
        {
            this.server = "localhost";
            this.database = "acelist";
            this.uid = "root";
            this.password = "wakacipuy";
            string connectionString;
            connectionString = "SERVER=" + this.server + ";" + "DATABASE=" +
            this.database + ";" + "UID=" + this.uid + ";" + "PASSWORD=" + this.password + ";";

            this.connection = new MySqlConnection(connectionString);
        }

        private void setArrItemId()
        {
            this.item_id = new List<int>();
            string sqlQuery = "select item_id from menu";
            MySqlCommand myCommand = new MySqlCommand(sqlQuery, this.connection);
            connection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    this.item_id.Add(myReader.GetInt32(0));
                }
            }
            finally
            {
                myReader.Close();
                connection.Close();
            }
        }

        public List<int> getArrItemId()
        {
            return item_id;
        }

        private void setArrItemName()
        {
            this.item_name = new List<string>();
            string sqlQuery = "select item_name from menu";
            MySqlCommand myCommand = new MySqlCommand(sqlQuery, this.connection);
            connection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    this.item_name.Add(myReader.GetString(0));
                }
            }
            finally
            {
                myReader.Close();
                connection.Close();
            }
        }
        public List<string> getArrItemName()
        {
            return item_name;
        }
        private void setArrItemPrice()
        {
            this.item_price = new List<int>();
            string sqlQuery = "select item_price from menu";
            MySqlCommand myCommand = new MySqlCommand(sqlQuery, this.connection);
            connection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    this.item_price.Add(myReader.GetInt32(0));
                }
            }
            finally
            {
                myReader.Close();
                connection.Close();
            }
        }
        public List<int> getArrItemPrice()
        {
            return item_price;
        }

        public string getNameFromItemId(int itemid)
        {
            int i = 0;
            bool found = false;
            while (found == false && i < this.item_id.Count)
            {
                if (itemid == this.item_id[i])
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }
            return item_name[i];
        }
        public int getPriceFromItemId(int itemid)
        {
            int i = 0;
            bool found = false;
            while (found == false && i < this.item_id.Count)
            {
                if (itemid == this.item_id[i])
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }
            return item_price[i];
        }

        public int getItemIdFromItemName(string itemname)
        {
            int i = 0;
            bool found = false;
            while (found == false && i < this.item_id.Count)
            {
                if (itemname == this.item_name[i])
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }
            return item_id[i];
        }

    }

    
}
