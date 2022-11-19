﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acelist.entities
{
    public class Customer
    {
        private List<string> customer_id = new List<string>();
        private List<string> customer_name = new List<string>();
        private List<string> email = new List<string>();
        private List<string> phone = new List<string>();

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Customer()
        {
            initialize();
        }
        public void initialize()
        {
            myCon();
            setArrCustomerId();
            setArrCustomerName();
            setArrEmail();
            setArrPhoneNumber();
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

        private void setArrCustomerName()
        {
            this.customer_name = new List<string>();
            string sqlQuery = "select customer_name from customer";
            MySqlCommand myCommand = new MySqlCommand(sqlQuery, this.connection);
            connection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    this.customer_name.Add(myReader.GetString(0));
                }
            }
            finally
            {
                myReader.Close();
                connection.Close();
            }
        }
        public List<string> getArrCustomerName()
        {
            return customer_name;
        }

        private void setArrCustomerId()
        {
            this.customer_id = new List<string>();
            string sqlQuery = "select customer_id from customer";
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
        public List<string> getArrCustomerId()
        {
            return customer_id;
        }

        private void setArrEmail()
        {
            this.email = new List<string>();
            string sqlQuery = "select email from customer";
            MySqlCommand myCommand = new MySqlCommand(sqlQuery, this.connection);
            connection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    this.email.Add(myReader.GetString(0));
                }
            }
            finally
            {
                myReader.Close();
                connection.Close();
            }
        }
        public List<string> getArrEmail()
        {
            return email;
        }

        private void setArrPhoneNumber()
        {
            this.phone = new List<string>();
            string sqlQuery = "select phone_number from customer";
            MySqlCommand myCommand = new MySqlCommand(sqlQuery, this.connection);
            connection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    this.phone.Add(myReader.GetString(0));
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
            return phone;
        }

        public bool isIDExist(string cid)
        {
            int i = 0;
            bool found = false;

            while (found == false && i < customer_id.Count)
            {
                if (customer_id[i] == cid)
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
