using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_API.Data.Class
{
    class EducationAgreementOrigin
    {
        string name;
        public EducationAgreementOrigin()
        {

        }

        EducationAgreementOrigin(string name)
        {
            this.name = name;
        }

        public String Name
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
    }
}
