using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_API.DAL.Interfaces
{
    interface IDatabase
    {
        void OpenConnection();
        void CloseConnection();
    }
}
