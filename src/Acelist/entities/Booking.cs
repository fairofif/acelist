using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Acelist.boundary.popupform;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Acelist.entities
{
    public class Booking
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        private List<int> booking_id = new List<int>();
        private List<int> room_id = new List<int>();
        private List<string> customer_id = new List<string>();
        private List<string> employee_id = new List<string>();
        private List<DateTime> booking_time = new List<DateTime>();
        private List<DateTime> checkin_time = new List<DateTime>();
        private List<DateTime> checkout_time = new List<DateTime>();
        private List<bool> has_checked_in = new List<bool>();
        private List<bool> has_checked_out = new List<bool>();

        public Booking()
        {
            Initialize();
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
        public void Initialize()
        {
            myCon();

            setArrBookingID();
            setArrBookingTime();
            setArrCustomerID();
            setArrEmployeeID();
            setArrCheckinTime();
            setArrCheckoutTime();
            setArrRoomID();
            setArrHasCheckedIn();
            setArrHasCheckedOut();
        }

        private void setArrBookingID()
        {
            this.booking_id = new List<int>();
            string sqlQuery = "select booking_id from booking order by booking_id";
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

        public List<int> getArrBookingID()
        {
            return this.booking_id;
        }

        private void setArrRoomID()
        {
            this.room_id = new List<int>();
            string sqlQuery = "select room_id from booking order by booking_id";
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

        public List<int> getArrRoomID()
        {
            return this.room_id;
        }

        private void setArrCustomerID()
        {
            this.customer_id = new List<string>();
            string sqlQuery = "select customer_id from booking order by booking_id";
            MySqlCommand myCommand = new MySqlCommand(sqlQuery, this.connection);
            connection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    this.customer_id.Add(myReader.GetString(0));
                }
            }
            finally
            {
                myReader.Close();
                connection.Close();
            }
        }

        public List<string> getArrCustomerID()
        {
            return this.customer_id;
        }

        private void setArrEmployeeID()
        {
            this.employee_id = new List<string>();
            string sqlQuery = "select employee_id from booking order by booking_id";
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

        public List<string> getArrEmployeeID()
        {
            return this.employee_id;
        }

        private void setArrBookingTime()
        {
            this.booking_time = new List<DateTime>();
            string sqlQuery = "select booking_time from booking order by booking_id";
            MySqlCommand myCommand = new MySqlCommand(sqlQuery, this.connection);
            connection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    this.booking_time.Add(myReader.GetDateTime(0));
                }
            }
            finally
            {
                myReader.Close();
                connection.Close();
            }
        }

        public List<DateTime> getArrBookingTime()
        {
            return this.booking_time;
        }

        private void setArrCheckinTime()
        {
            this.checkin_time = new List<DateTime>();
            string sqlQuery = "select checkin_time from booking order by booking_id";
            MySqlCommand myCommand = new MySqlCommand(sqlQuery, this.connection);
            connection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    this.checkin_time.Add(myReader.GetDateTime(0));
                }
            }
            finally
            {
                myReader.Close();
                connection.Close();
            }
        }

        public List<DateTime> getArrCheckinTime()
        {
            return this.checkin_time;
        }

        private void setArrCheckoutTime()
        {
            this.checkout_time = new List<DateTime>();
            string sqlQuery = "select checkout_time from booking order by booking_id";
            MySqlCommand myCommand = new MySqlCommand(sqlQuery, this.connection);
            connection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    this.checkout_time.Add(myReader.GetDateTime(0));
                }
            }
            finally
            {
                myReader.Close();
                connection.Close();
            }
        }

        public List<DateTime> getArrCheckoutTime()
        {
            return this.checkout_time;
        }

        private void setArrHasCheckedIn()
        {
            this.has_checked_in = new List<bool>();
            string sqlQuery = "select has_checked_in from booking order by booking_id";
            MySqlCommand myCommand = new MySqlCommand(sqlQuery, this.connection);
            connection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    this.has_checked_in.Add(myReader.GetBoolean(0));
                }
            }
            finally
            {
                myReader.Close();
                connection.Close();
            }
        }

        public List<bool> getArrHasCheckedIn()
        {
            return this.has_checked_in;
        }

        private void setArrHasCheckedOut()
        {
            this.has_checked_out = new List<bool>();
            string sqlQuery = "select has_checked_out from booking order by booking_id";
            MySqlCommand myCommand = new MySqlCommand(sqlQuery, this.connection);
            connection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    this.has_checked_out.Add(myReader.GetBoolean(0));
                }
            }
            finally
            {
                myReader.Close();
                connection.Close();
            }
        }

        public List<bool> getArrHasCheckedOut()
        {
            return this.has_checked_out;
        }

        public int findIdx(int bookid)
        {
            int i = 0;
            bool found = false;
            while (found == false && i < this.booking_id.Count)
            {
                if (booking_id[i] == bookid)
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

        public void updateHasCheckedin(int bookid, bool status)
        {
            string sqlQuery;
            if (status == false)
            {
                sqlQuery = "update booking set has_checked_in = false where booking_id = " + bookid.ToString();
            }
            else
            {
                sqlQuery = "update booking set has_checked_in = true where booking_id = " + bookid.ToString();
            }
            connection.Open();
            MySqlCommand myCommand = new MySqlCommand(sqlQuery, this.connection);
            myCommand.ExecuteNonQuery();
            connection.Close();

            Initialize();
        }

        public void updateHasCheckedout(int bookid, bool status)
        {
            string sqlQuery;
            if (status == false)
            {
                sqlQuery = "update booking set has_checked_out = false where booking_id = " + bookid.ToString();
            }
            else
            {
                sqlQuery = "update booking set has_checked_out = true where booking_id = " + bookid.ToString();
            }
            connection.Open();
            MySqlCommand myCommand = new MySqlCommand(sqlQuery, this.connection);
            myCommand.ExecuteNonQuery();
            connection.Close();

            Initialize();
        }

        public int getRoomIdByBookId(int bookid)
        {
            int i = 0;
            bool found = false;
            while (found == false && i < room_id.Count)
            {
                if (booking_id[i] == bookid)
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }
            return room_id[i];
        }

        public void addBooking(string idCust, string empID, string rid, DateTime bookCreated, DateTime checkin, DateTime checkout)
        {
            this.Initialize();
            string bookid = (booking_id[booking_id.Count - 1]+1).ToString();
            string roomid = rid;
            string bookingday = bookCreated.Year.ToString() + "-" + bookCreated.Month.ToString() + "-" + bookCreated.Day.ToString();
            string checkinday = checkin.Year.ToString() + "-" + checkin.Month.ToString() + "-" + checkin.Day.ToString();
            string checkoutday = checkout.Year.ToString() + "-" + checkout.Month.ToString() + "-" + checkout.Day.ToString();

            string values = "("+bookid+","+roomid + ",'" + idCust + "','" + empID + "','" + bookingday + "','" + checkinday + "','" + checkoutday + "',false, false)";
            string query = "insert into booking values " + values;

            connection.Open();
            MySqlCommand myCommand = new MySqlCommand(query, this.connection);
            myCommand.ExecuteNonQuery();
            connection.Close();
            Initialize();
        }

        public void deleteBooking(int bookid)
        {
            int z = booking_id.Count;
            string query = "delete from booking where booking_id = " + bookid;
            connection.Open();
            MySqlCommand myCommand = new MySqlCommand(query, this.connection);
            myCommand.ExecuteNonQuery();
            connection.Close();
            Initialize();
        }

        public bool isCustExist(string idcust)
        {
            Initialize();
            bool found = false;
            int i = 0;
            while (found == false && i < booking_id.Count)
            {
                if (customer_id[i].ToString() == idcust)
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
    }

}
