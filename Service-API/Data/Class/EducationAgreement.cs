using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_API.Data.Class
{
    class EducationAgreement
    {
        // attributes
        private uint userId;
        private string educationAgreementOriginName;
        private string educationAgreementCategoryName;
        private string educationAgreementTypeName;
        private uint companyCVR;
        private DateTime startDate;
        private DateTime endDate;


        // properties
        public uint UserId { get => userId; private set => userId = value; }
        public string EducationAgreementOriginName { get => educationAgreementOriginName; private set => educationAgreementOriginName = value; }
        public string EducationAgreementCategoryName { get => educationAgreementCategoryName; private set => educationAgreementCategoryName = value; }
        public string EducationAgreementTypeName { get => educationAgreementTypeName; private set => educationAgreementTypeName = value; }
        public uint CompanyCVR { get => companyCVR; private set => companyCVR = value; }
        public DateTime StartDate { get => startDate; private set => startDate = value; }
        public DateTime EndDate { get => endDate; private set => endDate = value; }

        // constructor
        public EducationAgreement(uint userId, string educationAgreementOriginName, string educationAgreementCategoryName, string educationAgreementTypeName, uint companyCVR, DateTime startDate, DateTime endDate)
        {
            UserId = userId;
            EducationAgreementOriginName = educationAgreementOriginName;
            EducationAgreementCategoryName = educationAgreementCategoryName;
            EducationAgreementTypeName = educationAgreementTypeName;
            CompanyCVR = companyCVR;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
