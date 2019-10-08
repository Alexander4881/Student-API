using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Service_API.Logic
{
    class CSVConverter //: IFullDataCopling
    {
        // attributes
        private string path;

        public CSVConverter(string path)
        {
            this.path = path;
        }
    }
}
