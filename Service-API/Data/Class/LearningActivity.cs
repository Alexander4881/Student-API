using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_API.Data.Class
{
    class LearningActivity
    {
        uint userId;
        string name;
        uint schoolId;
        DateTime startDate;
        DateTime endDate;

        public LearningActivity()
        {

        }

        public LearningActivity(uint userId, uint schoolId)
        {

        }

        public uint UserId
        {
            get
            {
                return userId;
            }
            private set
            {
                userId = value;
            }
        }

        public uint SchoolId
        {
            get
            {
                return SchoolId;
            }
            private set
            {
                schoolId = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                startDate = value;
            }
        }

        public DateTime EndDate { get => endDate; private set => endDate = value; }
    }
}
