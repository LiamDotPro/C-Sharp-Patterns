using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Patterns.Proxy
{
    class Proxy : ISubject
    {
        Subject subject;

        /**
         * This request is a very simple proxy and doesn't exactly do much,
         * The idea behind having a request as part of a proxy is not so much to delegate
         * from the Interface the functionality that the subject class is to use.
         * 
         * The main idea behind a proxy could be the concept of 'layering' your access to
         * certain features within your application. 
         */
        public string Request()
        {
            if (subject == null) {
                Console.WriteLine("Subject has not been constructed.");
                subject = new Subject();
            }
            Console.WriteLine("Subject Active");
            return "Proxy: Call to " + subject.Request();
        }
    }
}
