using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Patterns.Decorator
{
    class Component : IComponent
    {
        // An error is implemented in the case that you don't actually provide a method that returns with an appropriate value.
        public string Operation()
        {
            return "Hello I'm a test decorator.";
        }
    }
}
