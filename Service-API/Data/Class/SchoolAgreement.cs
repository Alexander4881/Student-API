using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_API.Data.Class
{
    class SchoolAgreement
    {
        uint userId;
        uint schoolId;
        DateTime startDate;
        DateTime endDate;

        public SchoolAgreement()
        {

        }

        public SchoolAgreement(uint userId, uint schoolId, DateTime startDate, DateTime endDate)
        {
            this.userId = userId;
            this.schoolId = schoolId;
            this.startDate = startDate;
            this.endDate = endDate;
        }
    }
}
