using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acelist.entities
{
    public class Order
    {
        private List<int> booking_id = new List<int>();
        private List<int> item_id = new List<int>();
        private List<int> amount = new List<int>();
        private List<int> idx = new List<int>();

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Order()
        {
            myCon();
            initialize();
        }

        public void initialize()
        {
            setArrBookingId();
            setArrItemId();
            setArrAmount();
            setArrIdx();
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

        private void setArrBookingId()
        {
            this.booking_id = new List<int>();
            string sqlQuery = "select booking_id from orders order by idx";
            MySqlCommand myCommand = new MySqlCommand(sqlQuery, this.connection);
            connection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    this.booking_id.Add(myReader.GetInt32(0));
                }
            }
            finally
            {
                myReader.Close();
                connection.Close();
            }
        }

        public List<int> getArrBookingId()
        {
            return booking_id;
        }

        private void setArrItemId()
        {
            this.item_id = new List<int>();
            string sqlQuery = "select item_id from orders order by idx";
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

        private void setArrAmount()
        {
            this.amount = new List<int>();
            string sqlQuery = "select amount from orders order by idx";
            MySqlCommand myCommand = new MySqlCommand(sqlQuery, this.connection);
            connection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    this.amount.Add(myReader.GetInt32(0));
                }
            }
            finally
            {
                myReader.Close();
                connection.Close();
            }
        }

        public List<int> getArrAmount()
        {
            return amount;
        }

        private void setArrIdx()
        {
            this.idx = new List<int>();
            string sqlQuery = "select idx from orders";
            MySqlCommand myCommand = new MySqlCommand(sqlQuery, this.connection);
            connection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    this.idx.Add(myReader.GetInt32(0));
                }
            }
            finally
            {
                myReader.Close();
                connection.Close();
            }
        }

        public List<int> getArrIdx()
        {
            return idx;
        }

        public void addOrder(int bookid, int item_id, int amount)
        {
            int idx = booking_id.Count;
            string query = "insert into orders values ('"+(idx+1).ToString()+"','"+bookid.ToString()+"','"+item_id.ToString()+"','"+amount.ToString()+"')";
            connection.Open();
            MySqlCommand myCommand = new MySqlCommand(query, this.connection);
            myCommand.ExecuteNonQuery();
            connection.Close();
            initialize();
        }

        public void deleteOrder(int idxOrder)
        {
            int z = booking_id.Count;
            string query = "delete from orders where idx = " + idxOrder;
            connection.Open();
            MySqlCommand myCommand = new MySqlCommand(query, this.connection);
            myCommand.ExecuteNonQuery();
            connection.Close();
            for (int i = idxOrder+1; i < z+1; i++)
            {
                query = "update orders set idx = " + (i-1).ToString() +" where idx = "+ (i).ToString();
                connection.Open();
                myCommand = new MySqlCommand(query, this.connection);
                myCommand.ExecuteNonQuery();
                connection.Close();
            }
            initialize();
        }
    }
}
