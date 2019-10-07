using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_API.Logic
{
    class Ldap
    {
        // attributes
        private PrincipalContext ldapContext;

        // properties
        public PrincipalContext LdapContext { get => ldapContext; set => ldapContext = value; }

        // constructor
        public Ldap()
        {

        }
    }
}
