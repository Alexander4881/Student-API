using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_API.Data.Class
{
    class SchoolCourse
    {
        uint userId;
        uint schoolId;
        string name;
        DateTime startDate;
        DateTime endDate;
        bool schoolDorm;

        public SchoolCourse()
        {

        }

        public SchoolCourse(uint userId, uint schoolId, string SchoolCourse, DateTime startDate, DateTime endDate)
        {

        }

        public uint UserId { get => userId; private set => userId = value; }
        public uint SchoolId { get => schoolId; private set => schoolId = value; }
        public string Name { get => name; private set => name = value; }
        public DateTime StartDate { get => startDate; private set => startDate = value; }
        public DateTime EndDate { get => endDate; private set => endDate = value; }
        public bool SchoolDorm { get => schoolDorm; private set => schoolDorm = value; }
    }
}
