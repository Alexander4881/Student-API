using Service_API.Data.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_API.Logic.Class
{
    class EducationalConnection
    {
        // attributes
        private Specialization specialization;
        private Education education;

        // properties
        public Specialization Specialization { get => specialization; private set => specialization = value; }
        public Education Education { get => education; private set => education = value; }

        // constructor
        private EducationalConnection() { }
        public EducationalConnection(Specialization specialization, Education education)
        {
            Specialization = specialization;
            Education = education;
        }
    }
}
