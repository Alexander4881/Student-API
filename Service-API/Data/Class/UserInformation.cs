using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_API.Logic.Class
{
    class UserInformation
    {
        // attributes
        private uint userId;
        private int companyCvr;
        private string educationName;
        private DateTime startDate;
        private DateTime endDate;

        // properties
        public uint UserId { get => userId; set => userId = value; }
        public int CompanyCvr { get => companyCvr; set => companyCvr = value; }
        public string EducationName { get => educationName; set => educationName = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }

        // constructor
        private UserInformation() { }
        public UserInformation(uint userId, int companyCvr, string educationName, DateTime startDate, DateTime endDate)
        {
            UserId = userId;
            CompanyCvr = companyCvr;
            EducationName = educationName;
            StartDate = startDate;
            EndDate = endDate;
        }

    }
}
