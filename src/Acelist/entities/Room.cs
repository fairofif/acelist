using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acelist.entities
{
    public class Room
    {
        private List<int> room_id = new List<int>();
        private List<string> room_type = new List<string>();
        private List<int> room_price = new List<int>();
        private List<int> floor = new List<int>();

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Room()
        {
            myCon();
            setArrRoomId();
            setArrRoomType();
            setArrRoomPrice();
            setArrFloor();
        }
        private void myCon()
        {
            this.server = "128.199.189.176";
            this.database = "acelistj_acelist";
            this.uid = "acelistj_rofif";
            this.password = "Wakacipuy09";
            string connectionString;
            connectionString = "SERVER=" + this.server + ";" + "DATABASE=" +
            this.database + ";" + "UID=" + this.uid + ";" + "PASSWORD=" + this.password + ";";

            this.connection = new MySqlConnection(connectionString);
        }

        private void setArrRoomId()
        {
            this.room_id = new List<int>();
            string sqlQuery = "select room_id from room";
            MySqlCommand myCommand = new MySqlCommand(sqlQuery, this.connection);
            connection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    this.room_id.Add(myReader.GetInt32(0));
                }
            }
            finally
            {
                myReader.Close();
                connection.Close();
            }
        }
        public List<int> getArrRoomId()
        {
            return room_id;
        }
        private void setArrRoomType()
        {
            this.room_type = new List<string>();
            string sqlQuery = "select room_type from room";
            MySqlCommand myCommand = new MySqlCommand(sqlQuery, this.connection);
            connection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    this.room_type.Add(myReader.GetString(0));
                }
            }
            finally
            {
                myReader.Close();
                connection.Close();
            }
        }
        public List<string> getArrRoomType()
        {
            return room_type;
        }
        private void setArrRoomPrice()
        {
            this.room_price = new List<int>();
            string sqlQuery = "select room_price from room";
            MySqlCommand myCommand = new MySqlCommand(sqlQuery, this.connection);
            connection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    this.room_price.Add(myReader.GetInt32(0));
                }
            }
            finally
            {
                myReader.Close();
                connection.Close();
            }
        }
        public List<int> getArrRoomPrice()
        {
            return room_price;
        }
        private void setArrFloor()
        {
            this.floor = new List<int>();
            string sqlQuery = "select floor from room";
            MySqlCommand myCommand = new MySqlCommand(sqlQuery, this.connection);
            connection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    this.floor.Add(myReader.GetInt32(0));
                }
            }
            finally
            {
                myReader.Close();
                connection.Close();
            }
        }
        public List<int> getArrFloor()
        {
            return floor;
        }

        public int getPriceByRoomId(int roomid)
        {
            int i = 0;
            bool found = false;
            while (found == false && i < room_id.Count)
            {
                if (room_id[i] == roomid)
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }
            return room_price[i];
        }

        public string getTypeByRoomId(int roomid)
        {
            int i = 0;
            bool found = false;
            while (found == false && i < room_id.Count)
            {
                if (room_id[i] == roomid)
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }
            return room_type[i];
        }
    }
}
