using Student_API.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_API.Logic
{
    public class QueryService
    {
        #region Attributes
        private readonly Command cmd = new Command();
        #endregion

        #region Properties
        public Command Cmd
        {
            get { return cmd; }
        }
        #endregion


    }
}
