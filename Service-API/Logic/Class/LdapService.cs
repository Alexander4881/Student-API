using Service_API.Data.Class;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_API.Logic.Class
{
    public class LdapService
    {
        private UserPrincipal userPrincipal;
        private PrincipalSearcher searchUser;
        private string userInfo;

        public string LdapGetCommonName(string firstName, string lastName)
        {
            Ldap ldap = Ldap.Instance;

            PrincipalContext ctx = ldap.GetPrincipalContext;
            userPrincipal = new UserPrincipal(ctx);
            searchUser = new PrincipalSearcher();

            try
            {
                if ((firstName != "" && firstName.Length != 0) && (lastName != "" && lastName.Length != 0))
                {
                    userPrincipal.GivenName = firstName;
                    userPrincipal.Surname = lastName;

                    searchUser.QueryFilter = userPrincipal;
                    PrincipalSearchResult<Principal> results = searchUser.FindAll();

                    foreach (UserPrincipal name in results)
                    {
                        if (!name.Name.Contains("zbc"))
                        {
                            return name.Name;
                        }
                    }
                    return $"No Account Found.";
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception: {ex.Message}");
                userInfo = "User not found.";
                return userInfo;
            }
            finally
            {
                if (ctx != null)
                {
                    ctx.Dispose();
                    Debug.WriteLine($"Disposed: Context");
                }
                if (userPrincipal != null)
                {
                    userPrincipal.Dispose();
                    Debug.WriteLine($"Disposed: User Principal.");
                }
                if (searchUser != null)
                {
                    searchUser.Dispose();
                    Debug.WriteLine($"Disposed: Search User.");
                }
            }
            return userInfo;
        }
    }
}
