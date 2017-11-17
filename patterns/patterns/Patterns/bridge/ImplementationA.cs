using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Patterns.bridge
{
    class ImplementationA : IBridge
    {
        public string OperationImp()
        {
            return "Implemention A";
        }
    }
}
