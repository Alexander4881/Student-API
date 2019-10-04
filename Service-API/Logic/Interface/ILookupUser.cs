using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_API.Logic.Interface
{
    interface ILookupUser
    {
        public string ILookupUser(string firstName, string lastName);
    }
}
