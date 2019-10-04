using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_API.Data.Class
{
    class School
    {
        uint schoolId;
        string name;

        public School()
        {

        }

        public School(uint SchoolId, string name)
        {
            
        }

        public uint SchoolId 
        {
            get
            {
                return schoolId;//Alexander sucks php rocks
            }
            private set
            {
                schoolId = value;
            }
        }
    }
}
