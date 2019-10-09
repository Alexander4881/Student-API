using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_API.Data.Class
{
    class Company
    {
        uint cvr;
        string name;
        int sequentialId;

        public Company()
        {

        }

        public Company(uint cvr, string name, int sequentialId)
        {
            this.Cvr = cvr;
            this.Name = name;
            this.SequentialId = sequentialId;
        }

        public uint Cvr { get => cvr; private set => cvr = value; }
        public string Name { get => name; private set => name = value; }
        public int SequentialId { get => sequentialId; private set => sequentialId = value; }
    }
}
