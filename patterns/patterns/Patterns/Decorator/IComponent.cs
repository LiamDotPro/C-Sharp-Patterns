using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Patterns.Decorator
{
    /**
     * By adding <T> to the componenet we can directly assert that when invoked on a class an object type will be passed.
     */
    interface IComponent
    {
        /**
         * Interfaces can not include a defined function like java.
         **/
        string Operation();
    }
}
