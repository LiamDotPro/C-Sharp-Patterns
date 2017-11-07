using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Patterns.Decorator
{
    class DecoratorA : IComponent
    {
        IComponent component;

        public DecoratorA(IComponent c) {
            component = c;
        }

        public string Operation()
        {
            string s = component.Operation();
            s += " Added value";
            return s;
        }
    }
}
