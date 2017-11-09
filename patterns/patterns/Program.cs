using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using patterns.Patterns.Decorator;
using patterns.Patterns.Inheritance;
using patterns.Patterns.Proxy;

namespace patterns
{
    class Program
    {
        /**
         * You can only call methods that are static from within static functions.
         **/
        static void Main(string[] args)
        {
            // Basic Inheritance
            //Inheritance();

            // Decorator - 1 
            // SimpleDecorator();

            // Proxy - 2
            SimpleProxy();
        }

        private static void Inheritance()
        {
            IAccountable SavingsAcc = new SavingsAccount("Barclays", 0.2, "Liam", 20000);
            Console.ReadLine();
        }

        private static void SimpleDecorator()
        {
            /**
             * This will form the basis for checking our patterns as I run through the book CSharp Patterns..
             **/

            // There's a big plus to implementing this as an interface for a good reason.

            /**
             * If we consider a method that only takes the parameter IComponent we can see the value of
             * accurately defining it as the composable interface
             * 
             * public void (IComponent myComponent){
             *      
             * }
             * 
             * This also gives us options down the line to change the concerete class while still maintaining that
             * the object will follow the outlined interface.
             */

            // Invoke base componenet
            IComponent c = new Component();

            // Invoke Decorator and pass componenet in constructor.
            DecoratorA a = new DecoratorA(c);

            // Call operation on the decorator, this will call operation from within the concrete class
            // and then proceed to add extra value 'decorate' the output when returning for println...
            Console.WriteLine(a.Operation());
            Console.ReadLine();

            /**
             * The Decorator is a good pattern to follow when you have only a single class you want to inherit
             * or build up off. Typically if you can see that you are lightly to decorate any more than off the orginal
             * you have to remeber that another layer will not have access to the orginal object, In this case you'd find
             * more success using something like the strategy pattern.
             */
        }

        private static void SimpleProxy()
        {
            ISubject subject = new Proxy();
            Console.WriteLine(subject.Request());
            Console.ReadLine();

            ProtectedProxy protectedSubject = new ProtectedProxy();
            Console.WriteLine(protectedSubject.Request());
            Console.WriteLine(protectedSubject.Authenticate("DumDeeDa"));
            Console.ReadLine();
        }
    }
}
