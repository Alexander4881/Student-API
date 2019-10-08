using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_API.Data.Class
{
    class Education
    {
        // attributes
        private string name;
        private string version;

        // properties
        public string Name { get => name; private set => name = value; }
        public string Version { get => version; private set => version = value; }
        
        // constructor
        public Education(string name, string version)
        {
            Name = name;
            Version = version;
        }
    }
}
