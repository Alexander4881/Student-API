using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_API.Data.Class
{
    class User
    {
        // attributes
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private string uniUser;
        private uint userId;

        // properties
        public string FirstName { get => firstName; private set => firstName = value; }
        public string LastName { get => lastName; private set => lastName = value; }
        public DateTime BirthDate { get => birthDate; private set => birthDate = value; }
        public string UniUser { get => uniUser; private set => uniUser = value; }
        public uint UserId { get => userId; private set => userId = value; }
        
        // constructor
        public User(string firstName, string lastName, DateTime birthDate, string uniUser, uint userId)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            UniUser = uniUser;
            UserId = userId;
        }
    }
}
