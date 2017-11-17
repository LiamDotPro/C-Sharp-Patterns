using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Patterns.bridge
{
    class ImplementationB : IBridge
    {
        public string OperationImp()
        {
            return "Implementation B";
        }
    }
}
