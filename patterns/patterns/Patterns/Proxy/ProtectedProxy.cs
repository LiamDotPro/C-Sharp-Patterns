using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Patterns.Proxy
{
    class ProtectedProxy : ISubject
    {
        Subject subject;

        /**
         * If you were planning on using this to authenticate in a real world,
         * soulution a good design approach would be to include a authentication level
         * either through inheritance (Worst approach) or by simply including an authentication
         * layer which decorates the basic database access classes you could commonly use.
         */
        string password = "DumDeeDa";

        public string Authenticate(string password)
        {
            // In this case we have to use the this operator as we choose to use the same parameter name
            // You'd obviously want to use either _password (Bad) or better you would use a lond descriptor.
            if (this.password != password)
            {
                return "You do not have access to this resource.";
            }
            else
            {
                subject = new Subject();
                return "You've successfully authenticated this resource.";
            }
        }

        public string Request()
        {
            if (subject == null)
            {
                return "You are not authenticated.";
            }
            else
            {
                // Poor example but it works...
                return "Access Granted";
            }
        }
    }
}
