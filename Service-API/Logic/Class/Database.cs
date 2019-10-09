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

namespace Service_API.Logic
{
    class Database : IDatabase, IDataInsert//, IFullDataCopling
    {
        // attributes
        private Database instance = null;
        private readonly string dbConnectionString;
        private MySqlConnection connection = null;

        // properties
        public MySqlConnection Connection { get => connection; private set => connection = value; }
        public Database Instance
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
        private Database(){ }

        public void InsertData(IList<object> data)
        {
            // TODO: make a switch on type 
            foreach (object dataObject in data)
            {
                switch (dataObject)
                {
                    case Education education:

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
                    string connstring = string.Format("Server=localhost; database=StudentAPI; UID=root; password=");
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
    }
}
