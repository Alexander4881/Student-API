using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_API.Interfaces
{
    interface IDatabase
    {
        public void OpenConnection();
        public void CloseConnection();
    }
}
