using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_API.Data.Class
{
    class SpecialAgreement
    {
        // attributes
        private int userId;
        private string specialAgreementListName;
        private DateTime startDate;
        private DateTime endDate;
        private string description;

        // properties
        public int UserId { get => userId; private set => userId = value; }
        public string SpecialAgreementListName { get => specialAgreementListName; private set => specialAgreementListName = value; }
        public DateTime StartDate { get => startDate; private set => startDate = value; }
        public DateTime EndDate { get => endDate; private set => endDate = value; }
        public string Description { get => description; private set => description = value; }
        
        // constructor
        public SpecialAgreement(int userId, string specialAgreementListName, DateTime startDate, DateTime endDate, string description)
        {
            UserId = userId;
            SpecialAgreementListName = specialAgreementListName;
            StartDate = startDate;
            EndDate = endDate;
            Description = description;
        }
    }
}
