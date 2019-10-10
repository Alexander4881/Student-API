using Service_API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using Service_API.Data.Class;
using Service_API.Logic.Class;
using System.Diagnostics;
using Service_API.Logic;
using System.Configuration;

namespace Service_API.Data
{
    class Database : IDatabase, IDataInsert//, IFullDataCopling
    {
        // attributes
        private static Database instance = null;
        private MySqlConnection connection = null;

        // properties
        public MySqlConnection Connection { get => connection; private set => connection = value; }
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

        public void InsertData(IList<object> data)
        {
            // TODO: make a switch on type 
            foreach (object dataObject in data)
            {



                switch (dataObject)
                {
                    case Education education:

                        OpenConnection();

                        MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO `studentapi`.`education`(`name`,`version`)" +
                            "VALUES('" + education.Name + "','" + education.Version + "');", Connection);


                        CloseConnection();

                        break;

                    case EducationAgreement educationAgreement:

                        break;

                    case EducationAgreementSubType educationAgreementSubType:

                        break;

                    case LearningActivity learningActivity:

                        break;

                    case School school:

                        break;

                    case SpecialAgreement specialAgreement:

                        break;

                    case SpecialAgreementList specialAgreementList:

                        break;

                    case Specialization specialization:

                        break;

                    case User user:

                        break;

                    case UserInformation userInformation:

                        break;

                    default:
                        break;
                }
            }
        }

        public void OpenConnection()
        {
            try
            {
                if (Connection == null)
                {
                    string connstring = ConfigurationManager.ConnectionStrings["XAMPP"]?.ConnectionString;
                    Connection = new MySqlConnection(connstring);
                    Connection.Open();
                }
            }
            catch (Exception e)
            {
                LogMessage logMessage = new LogMessage("EXCEPTION cast at Database line 61 \n " + e, Data.Emum.Enums.MessageType.Error);
                Log.Instance.MessageQueue.Enqueue(logMessage);
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (connection != null)
                {
                    Connection.Close();
                }
            }
            catch (Exception e)
            {
                LogMessage logMessage = new LogMessage("EXCEPTION cast at Database line 77 \n " + e, Data.Emum.Enums.MessageType.Error);
                Log.Instance.MessageQueue.Enqueue(logMessage);
            }
        }

        public void ExecuteNonQuerryCommands(List<MySqlCommand> commands)
        {
            try
            {
                OpenConnection();
                // loop throug commands and executes
                foreach (MySqlCommand command in commands)
                {
                    // executes command
                    command.ExecuteNonQuery();
                }

                // close connection
                CloseConnection();
            }
            catch (Exception e)
            {
                LogMessage logMessage = new LogMessage("EXCEPTION cast at Database line 147 \n " + e, Data.Emum.Enums.MessageType.Error);
                Log.Instance.MessageQueue.Enqueue(logMessage);
            }
        }

        public bool CheckForeignKey(MySqlCommand command)
        {
            try
            {
                OpenConnection();

                

                CloseConnection();
            }
            catch (Exception e)
            {
                LogMessage logMessage = new LogMessage("EXCEPTION cast at Database line 61 \n " + e, Data.Emum.Enums.MessageType.Error);
                Log.Instance.MessageQueue.Enqueue(logMessage);
                return false;
            }

            return true;
        }
    }
}
