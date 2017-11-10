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
            // SimpleProxy();

            // Access Modifiers

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

        /***
         * In the case of a proxy class within c# it feels prudent to say that the they essentially
         * just encapsulate further functionality or protect sensitive data.
         * 
         * It's also useful to assert that you could use this pattern as a means to encapsulate high
         * risk classes and functionality within a sophisticated build where there is continous development
         * where developers are exspected to decorate or stategy out functionality.
         * 
         ***/
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

        /**
         * We have lots of good examples of Public and Private access modifers so I have choose to omit them.
         * 
         * This will be just a simple introduction to the modifers with descriptions.
         */
        private static void AccessModifiers()
        {

        }

        /**
         * Small side note that classes can not be encapsulated into local scope, though it's likely to be possible
         * using closures and then refferencing the variable as a local type if you have to work within the same package.
         */
        public class Modifers
        {
            // Protected is limited in scope to the project and it's derived classes, this however means that it shall
            // not be accesible to projects outside of this assembly.
            protected string _prot = "Protected Value";

            internal int Num = 22;

            protected internal double _double = 22.00;

            
        }
    }
}
