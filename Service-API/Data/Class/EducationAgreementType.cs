using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_API.Data.Class
{
    class EducationAgreementType
    {
        string name;

        EducationAgreementType()
        {

        }

        EducationAgreementType(string name)
        {
            this.Name = name;
        }

        public string Name { get => name; private set => name = value; }
    }
}
