using System;
using System.Collections.Generic;
using System.Configuration;
using MySql.Data.MySqlClient;
using Student_API.DAL.Interfaces;

namespace Student_API.DAL
{
    public class Database : IDatabase, IDisposable
    {
        // attributes
        private static Database instance = null;
        private MySqlConnection connection = null;
        private string connString;

        // properties
        public MySqlConnection Connection { get => connection; private set => connection = value; }

        public string ConnString
        {
            get { return connString; }
            private set { connString = value; }
        }

        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        // constructor
        private Database() { }

        public void OpenConnection()
        {
            try
            {
                if (Connection == null)
                {
                    Connection = new MySqlConnection(ConnString);
                    Connection.Open();
                }
            }
            catch (Exception ex)
            {
                // TODO
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (Connection != null)
                {
                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                // TODO
            }
        }

        public void Dispose()
        {
            Connection.Dispose();
        }
    }
}
