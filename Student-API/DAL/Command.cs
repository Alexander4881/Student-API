using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_API.DAL
{
    public class Command : IDisposable
    {
        #region Attributes
        private readonly Database db = Database.Instance;
        private MySqlCommand sqlCommand;
        #endregion

        #region Properties
        public Database DB
        {
            get { return db; }
        }

        public MySqlCommand SqlCommand
        {
            get { return sqlCommand; }
            private set { sqlCommand = value; }
        }
        #endregion

        public MySqlCommand InitCommand(string query)
        {
            DB.OpenConnection();
            SqlCommand = new MySqlCommand(query, DB.Connection);

            return SqlCommand;
        }

        public void Dispose()
        {
            SqlCommand.Dispose();
            DB.Dispose();
        }
    }
}
