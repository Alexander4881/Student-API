using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_API.Data.Class
{
    class EducationAgreementSubType
    {
        // attributes
        private uint userId;
        private uint agreementSubType;


        // properties
        public uint UserId { get => userId; private set => userId = value; }
        public uint AgreementSubType { get => agreementSubType; private set => agreementSubType = value; }
        
        // constructor
        public EducationAgreementSubType(uint userId, uint agreementSubType)
        {
            UserId = userId;
            AgreementSubType = agreementSubType;
        }
    }
}
