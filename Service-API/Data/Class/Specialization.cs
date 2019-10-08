using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_API.Data.Class
{
    class Specialization
    {
        // attributes
        private string name;
        private string description;

        // properties
        public string Name { get => name; private set => name = value; }
        public string Description { get => description; private set => description = value; }
        
        // properties
        public Specialization(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
