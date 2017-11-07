using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using patterns.Patterns.Decorator;

namespace patterns
{
    class Program
    {
        static void Main(string[] args)
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
             * @todo Extend this with a better example.
             */

            // Invoke base componenet
            IComponent c = new Component();

            // Invoke Decorator and pass componenet in constructor.
            DecoratorA a = new DecoratorA(c);

            // Call operation on the decorator, this will call operation from within the concrete class
            // and then proceed to add extra value 'decorate' the output when returning for println...
            Console.WriteLine(a.Operation());
            Console.ReadLine();


        }
    }
}
